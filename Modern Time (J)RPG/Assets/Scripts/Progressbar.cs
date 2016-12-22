using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Progressbar : MonoBehaviour
{

    Image foregroundImage;

    public int Value
    {
        get
        {
            if (foregroundImage != null)
                return (int)(foregroundImage.fillAmount * 100);
            else
                return 0;
        }
        set
        {
            if (foregroundImage != null)
                foregroundImage.fillAmount = value / 100f;
        }
    }

    void Start()
    {
        foregroundImage = gameObject.GetComponent<Image>();
        Value = 90;
    }

    //Testing: this function will be called when Test Button is clicked
    public void UpdateProgressbar()
    {
        Hashtable param = new Hashtable();
        param.Add("from", 0.0f);
        param.Add("to", 100);
        param.Add("time", 5.0f);
        param.Add("onupdate", "TweenedSomeValue");
        param.Add("onComplete", "OnFullProgress");
        param.Add("onCompleteTarget", gameObject);
        
    }

    public void TweenedSomeValue(int val)
    {
        Value = val;
    }

    public void OnFullProgress()
    {
        Value = 0;
    }
}