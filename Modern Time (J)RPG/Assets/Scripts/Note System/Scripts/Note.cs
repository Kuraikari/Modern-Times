using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]public class Note : MonoBehaviour {

    [Header("UI Text")]
    public Text title;
    public Text text;
    [Space(10)]

    [Header("Strings")]
    public string strTitle;
    public string strText;
    [Space(10)]
    bool saveButton;
    bool loadButton;
    string savebuttonname = "Save";
    string loadbuttonname = "Load";



    void OnGUI() {
        strTitle = GUI.TextArea(new Rect(525, 50, 350, 50), strTitle, 400);
        strText = GUI.TextArea(new Rect(525, 120, 350, 250), strText, 300);
        saveButton = GUI.Button(new Rect(550, 380, 100, 20), savebuttonname);
        loadButton = GUI.Button(new Rect(750, 380, 100, 20), loadbuttonname);


    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = strText;
        title.text = strTitle;

        //save Text
        if(saveButton == true) {
            PlayerPrefs.SetString("strTitle", strTitle);
            PlayerPrefs.SetString("strText", strText);

        }

        //load Text
        if (loadButton == true){
            strTitle = PlayerPrefs.GetString("strTitle");
            strText = PlayerPrefs.GetString("strText");
        }
	}
}
