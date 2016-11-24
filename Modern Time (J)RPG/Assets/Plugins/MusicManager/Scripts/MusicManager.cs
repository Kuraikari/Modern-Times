using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
	// The music player game object
	private static GameObject me = null;
	private static MusicPlayer mp = null;
	
	// Retreive or create the music emitter
	public static GameObject getMusicEmitter()
	{
		if(me == null)
		{
			me = new GameObject();
			me.name = "Music Emitter";
			me.AddComponent<AudioSource>();
			me.GetComponent<AudioSource>().loop = true;
			DontDestroyOnLoad(mp);
			mp = me.AddComponent<MusicPlayer>();
		}
		return me;
	}
	
	// Retreive or create the music player component of the emitter
	public static MusicPlayer getMusicPlayer()
	{
		if(mp == null)
		{
			mp = getMusicEmitter().GetComponent<MusicPlayer>();
			if(mp == null)
			{
				mp = me.AddComponent<MusicPlayer>();
			}
		}
		return mp;
	}
	
	// Play a music
	public static void play(AudioClip clip, float fadeOut = 0f, float fadeIn = 0f)
	{
		getMusicPlayer().playMusic(clip, fadeOut, fadeIn);
	}
	
	// Play a music with a filename in a Resources folder
	public static void play(string name, float fadeOut = 0f, float fadeIn = 0f)
	{
		AudioClip a = (AudioClip)Resources.Load(name, typeof(AudioClip));
		if(a != null){
			play(a, fadeOut, fadeIn);
		}
		else
		{
			Debug.Log("Could not find music \""+name+"\" in Resources folder.");
		}
	}
	
	// Set if the music should loop or not
	public static void setLoop(bool t)
	{
		getMusicEmitter().GetComponent<AudioSource>().loop = t;
	}
	
	// Pause the music
	public static void pause()
	{
		getMusicPlayer().pauseMusic();
	}
	
	// Unpause the music
	public static void unpause()
	{
		getMusicPlayer().unpauseMusic();
	}
	
	// Stop the music
	public static void stop(float fadeOut = 0f)
	{
		getMusicPlayer().stopMusic(fadeOut);
	}
	
	// Set the volume of the music
	public static void setVolume(float volume = 1.0f, float duration = 0f)
	{
		getMusicPlayer().setMusicVolume(volume, duration);
	}
}
