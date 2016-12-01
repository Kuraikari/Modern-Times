using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

/// <summary>
///     Author : Mamadou Cisse
/// 
///     Description :
///         class that represent a vocal synthetizer.
/// </summary>
public class SpeechEngine : MonoBehaviour
{

    #region ATTRIBUTES

    private Locale locale;
    private AndroidJavaObject currentlocale;
    private AndroidJavaObject engine;
    private AndroidJavaObject context;
    private static SpeechEngine instance;
    
    #endregion

    #region PROPERTIES

    /// <summary>
    /// property for engine enabled status
    /// </summary>
    public static bool IsEnabled
    {
        get {
            if (instance == null)
                return false;

            return PlayerPrefs.GetInt("ENABLED_SPEECH_ENGINE", 1) == 1 && instance.engine != null;
        }
        set
        {
            PlayerPrefs.SetInt("ENABLED_SPEECH_ENGINE", value ? 1 : 0);
        }
    }

    /// <summary>
    /// property for engine pitch value
    /// </summary>
    public static float PitchValue
    {
        get { return PlayerPrefs.GetFloat("SPEECH_ENGINE_PITCH_VALUE", 1.0f); }
        set
        {
            if (!IsEnabled)
                return;

            PlayerPrefs.SetFloat("SPEECH_ENGINE_PITCH_VALUE", value);
            instance.engine.Call("setPitch", value);
        }
    }

    /// <summary>
    /// property for engine speech rate value
    /// </summary>
    public static float SpeechRateValue
    {
        get { return PlayerPrefs.GetFloat("SPEECH_ENGINE_SPEECH_RATE_VALUE", 1.0f); }
        set
        {
            if (!IsEnabled)
                return;
            PlayerPrefs.SetFloat("SPEECH_ENGINE_SPEECH_RATE_VALUE", value);
            instance.engine.Call("setSpeechRate", value);
        }
    }

    #endregion

    #region UNITY_METHODS

    void Awake()
    {
        instance = this;
        locale = Locale.WhithName(PlayerPrefs.GetString("SPEECH_ENGINE_LANGUAGE", Locale.ENGLISH.ToString()));

#if UNITY_EDITOR
        Debug.Log("Speech Engine cannot be used in editor mode please launch this app in android device !");
#elif UNITY_ANDROID
       Init();
#else
        Debug.LogWarningFormat("SpeechEngine is not enable in this platform ");
#endif

        DontDestroyOnLoad(gameObject);
    }

    public void OnApplicationPause(bool pause)
    {
        if (pause)
            Stop();
    }

    public void OnApplicationQuit()
    {
        ShutDown();
    }

    #endregion

    #region OTHERS_METHODES

    /// <summary>
    /// init the vocal synthetizer
    /// </summary>
    private void Init()
    {

        if (engine == null)
        {
            using (AndroidJavaClass activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                context = activityClass.GetStatic<AndroidJavaObject>("currentActivity");
            }
            using (AndroidJavaClass cls = new AndroidJavaClass("fr.cisse.vocalsynthetizer.Engine"))
            {
                if (cls != null)
                {
                    engine = cls.CallStatic<AndroidJavaObject>("instance");
                    currentlocale = ToJavaLocaleObject(locale);

                    engine.Call("setContext", context);
                    engine.Call<bool>("InitEngine", currentlocale);
                }
            }
        }
    }

    /// <summary>
    /// Convert the locale object in parameter to java.util.Locale object and return it.
    /// </summary>
    /// <param name="locale"></param>
    /// <returns>java.util.Locale instance object</returns>
    private AndroidJavaObject ToJavaLocaleObject(Locale locale)
    {
        AndroidJavaObject javaLocaleObj = null;
        using (AndroidJavaClass cls = new AndroidJavaClass("java.util.Locale"))
        {
            if (Locale.Contains(locale))
                javaLocaleObj = cls.GetStatic<AndroidJavaObject>(locale.ToString());
            else
                javaLocaleObj = engine.Call<AndroidJavaObject>("createLocale", locale.language, locale.country);
        }
        return javaLocaleObj;
    }

    /// <summary>
    /// Change the engine language
    /// </summary>
    /// <param name="locale">new Locale</param>
    public static void SetLanguage(Locale locale)
    {
        if (instance == null)
            return;
        PlayerPrefs.SetString("SPEECH_ENGINE_LANGUAGE", locale.ToString());
        instance.currentlocale = instance.ToJavaLocaleObject(locale);
        instance.engine.Call("setLanguage", instance.currentlocale);

    }
  
    /// <summary>
    ///     Add listener to ui elements in parameter of the function
    /// </summary>
    /// <param name="toggle">the toggle that control the engine enable status</param>
    /// <param name="pitchSlider">slider that control engine pitch value</param>
    /// <param name="speechRateSlider">slider that control engine speech rate value</param>
    public static void AddListeners(Toggle toggle, Slider pitchSlider, Slider speechRateSlider)
    {

        toggle.isOn = IsEnabled;
        toggle.onValueChanged.AddListener((bool value)=>
        {
            IsEnabled = value;
            toggle.isOn = IsEnabled;

        });
          
       pitchSlider.value = (!IsEnabled) ? 0 : PitchValue;
       pitchSlider.onValueChanged.AddListener((float value) =>
       {
           PitchValue = value;
            
       });   

        speechRateSlider.value = (!IsEnabled) ? 0 : SpeechRateValue;
        speechRateSlider.onValueChanged.AddListener((float value) =>
        {
            SpeechRateValue = value;

        });
        
    }


    /// <summary>
    /// speak the message in parameter
    /// </summary>
    /// <param name="message">message to speak</param>
    public static void Speak(string message)
    {
        if (!IsEnabled)
            return;
        Stop();
        instance.engine.Call("speak", message);
    }


    /// <summary>
    /// speak the message in parameter and make pause
    /// each time ther is "{pause}" in message during  "time" secs
    /// </summary>
    /// <param name="message">the message to speak</param>
    /// <param name="time">pause time in seconds</param>
    /// <returns></returns>
    public static void SpeakWithPause(string message, int time)
    {
        if (!IsEnabled)
            return;
        instance.StartCoroutine(instance._SpeakWithPause(message, time));
    }

    private  IEnumerator _SpeakWithPause(string message, int time)
    {

        string[] stringSeparators = new string[] { "{pause}" };
        string[] sentences = message.Split(stringSeparators, System.StringSplitOptions.None);

        foreach (string s in sentences)
        {
            Speak(s);
            Pause(time);
            yield return new WaitForSeconds(time);
        }
        yield return null;
    }

    /// <summary>
    /// stop speaking
    /// </summary>
    public static void Stop()
    {
        if (!IsEnabled)
            return;
        instance.engine.Call("stop");
    }

    /// <summary>
    /// make an pause during "time" secs
    /// </summary>
    /// <param name="time">pause time in seconds</param>
    public static void Pause(int time)
    {
        if (instance == null)
            return;
        instance.engine.Call("pause", time * 1000);
    }

    /// <summary>
    /// stop the engine
    /// </summary>
    public static void ShutDown()
    {
        if (!IsEnabled)
            return;
        instance.engine.Call("shutDown");

    }

    #endregion
}
