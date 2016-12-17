using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneController : MonoBehaviour {

    
    public string nameOfScene;

    public void goToScene()
    { 
        SceneManager.LoadScene(nameOfScene); 
    }

    public void Start()
    {
       
    }
    public void Update()
    {

    }

}
