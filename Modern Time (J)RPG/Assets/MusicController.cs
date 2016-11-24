using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {
    MusicPlayer mp = new MusicPlayer();
    [Range(0, 10)]
    public int x, y;
    [Space(20)]
    public AudioClip[] songs;

    

    int index;



	// Use this for initialization
	void Start () {
        index = Random.Range(x, y);
        MusicManager.play(songs[index], 1f, 0.5f);
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
