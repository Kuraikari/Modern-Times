using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {
    [Range(0, 10)]
    public int x, y;
    [Space(20)]
    public AudioClip[] songs;

    

    int index;



	// Use this for initialization
	void Start () {
        index = Random.Range(x, y);
        if (!( GameObject.Find("Music Emitter - " + songs[index].ToString()) == MusicManager.getMusicEmitter()))
            MusicManager.play(songs[index], 0f, 0f);
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
