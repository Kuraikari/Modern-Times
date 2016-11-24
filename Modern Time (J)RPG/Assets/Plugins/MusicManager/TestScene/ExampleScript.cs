using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
	void OnGUI()
	{
		int y = 10;
		int stepy = 30;
		int width = 250;
		int height = 20;
		
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 1 (fade in/out: 5s/5s)"))
		{
			MusicManager.play("Dark Descent", 5.0f, 5.0f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 2 (fade in/out: 1s/1s)"))
		{
			MusicManager.play("The Dark Amulet", 1.0f, 1.0f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 2 (fade in/out: 3s/0.5s)"))
		{
			MusicManager.play("The Dark Amulet", 5.0f, 0.5f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Pause"))
		{
			MusicManager.pause();
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Unpause/Play"))
		{
			MusicManager.unpause();
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Stop the music (fadeOut of 3s)"))
		{
			MusicManager.stop(3.0f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 25% immediately"))
		{
			MusicManager.setVolume(0.25f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 25% over 3s"))
		{
			MusicManager.setVolume(0.25f, 3f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 100% immediately"))
		{
			MusicManager.setVolume(1.0f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 100% over 1s"))
		{
			MusicManager.setVolume(1.0f, 1.0f);
		}
		
		// Debug purposes
		// Also demonstrates how to get the gameObject which hold the music
		GameObject player = MusicManager.getMusicEmitter();
		if(player.GetComponent<AudioSource>().clip != null)
		{
			GUI.Label(new Rect(20+width, 10, 200, 30), "Music: "+player.GetComponent<AudioSource>().clip.name);
			GUI.Label(new Rect(20+width, 40, 200, 30), "Volume: "+player.GetComponent<AudioSource>().volume);
			GUI.Label(new Rect(20+width, 70, 200, 30), "Is playing: "+player.GetComponent<AudioSource>().isPlaying);
		}
	}
}
