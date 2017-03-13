using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneController : MonoBehaviour {


    public enum isTeleport { (Teleport, Scene, Both };
    public string nameOfScene;
    public string nameOfObject;
    private SpawnPoint sp = new SpawnPoint();

    public float xPos, yPos;

    public void goToScene() { 
        SceneManager.LoadScene(nameOfScene); 
    }

    public void teleportTo() {
        sp.obj = GameObject.Find(nameOfObject);
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.name == "Player" && (Boolean)isTeleport.Teleport == true) {
            goToScene();
        }
        else if (collision.name == "Player" && isTeleport == true) {
            teleportTo();
            collision.transform.position = sp.obj.transform.position + new Vector3(xPos, yPos);
        }
    }

    public void Start()
    {
       
    }
    public void Update()
    {

    }

}
