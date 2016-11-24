using UnityEngine;
using System.Collections;

// This class will manage the volume and the fade in/out effect of the music
public class MusicPlayer : MonoBehaviour
{
	// Private variables
	private enum MusicPlayerStatus{Playing,FadingOut,FadingIn}
	private MusicPlayerStatus status = MusicPlayerStatus.Playing;
	private AudioClip nextclip;
	// Fade in/out
	private float fadeOut;
	private float fadeIn;
	private float fadeStart;
	// Volume
	private float volume = 1.0f;
	private bool smoothVolume = false;
	private float smoothVolumeBeginValue;
	private float smoothVolumeDuration;
	private float smoothVolumeStart;
	
	// Private tween function
	// Parameters: elapsed time, begin value, end value, duration
	private float cubicInOut(float t, float b, float c, float d)
	{
		t /= d/2;
		if(t < 1)
			return c/2*t*t*t + b;
		t -= 2;
		return c/2*(t*t*t + 2) + b;
	}
	
	// Change the music's volume
	public void setMusicVolume(float volume, float duration)
	{
		// Sanitize input...
		if(volume < 0f) volume = 0f;
		if(volume > 1f) volume = 1f;
		
		// Set the new volume
		this.volume = volume;
		smoothVolumeBeginValue = GetComponent<AudioSource>().volume;
		smoothVolumeDuration = duration;
		smoothVolumeStart = Time.time;
		if(duration > 0f)
			smoothVolume = true;
		
		// If music is not in a fade effect, set it immediatly
		if(status != MusicPlayerStatus.FadingIn && status != MusicPlayerStatus.FadingOut && duration == 0f){
			GetComponent<AudioSource>().volume = volume;
		}
	}
	
	// Pause the music
	public void pauseMusic()
	{
		GetComponent<AudioSource>().Pause();
	}
	
	// Unpause the music
	public void unpauseMusic()
	{
		if(!GetComponent<AudioSource>().isPlaying)
			GetComponent<AudioSource>().Play();
	}
	
	// Play a new music
	public void playMusic(AudioClip a, float fadeOut, float fadeIn)
	{
		gameObject.name = "Music Emitter - "+a.name;
		if(GetComponent<AudioSource>().isPlaying)
		{
			// A music is already playing, so fade it out first
			this.fadeOut = fadeOut;
			this.fadeIn = fadeIn;
			nextclip = a;
			status = MusicPlayerStatus.FadingOut;
			fadeStart = Time.time;
		}
		else
		{
			// Directly play the music with the fadeIn effect
			this.fadeIn = fadeIn;
			GetComponent<AudioSource>().volume = 0;
			GetComponent<AudioSource>().clip = a;
			GetComponent<AudioSource>().Play();
			status = MusicPlayerStatus.FadingIn;
			fadeStart = Time.time;
		}
	}
	
	// Stop the music
	public void stopMusic(float fadeOut)
	{
		this.fadeOut = fadeOut;
		status = MusicPlayerStatus.FadingOut;
		fadeStart = Time.time;
	}
	
	// the Update function will do the fade in/out effect
	void Update()
	{
		// First, if the user want to change the volume
		if(smoothVolume)
		{
			if(status == MusicPlayerStatus.FadingOut || status == MusicPlayerStatus.FadingIn)
			{
				smoothVolume = false;
			}
			else
			{
				// Smooth the volume
				if(smoothVolumeBeginValue < volume)
					GetComponent<AudioSource>().volume = cubicInOut(Time.time-smoothVolumeStart, smoothVolumeBeginValue, volume, smoothVolumeDuration);
				else if(smoothVolumeBeginValue > volume)
					GetComponent<AudioSource>().volume = smoothVolumeBeginValue - cubicInOut(Time.time-smoothVolumeStart, 0f, smoothVolumeBeginValue-volume, smoothVolumeDuration);
				
				// If time is up we stop the animation
				if(Time.time > smoothVolumeStart+smoothVolumeDuration)
				{
					GetComponent<AudioSource>().volume = volume;
					smoothVolume = false;
				}
			}
		}
		
		// Now manage fade out/in
		if(status == MusicPlayerStatus.FadingOut)
		{
			if(Time.time < fadeStart+fadeOut)
			{
				GetComponent<AudioSource>().volume = volume - cubicInOut(Time.time-fadeStart, 0f, volume, fadeOut);
			}
			else
			{
				// Effect is finished
				GetComponent<AudioSource>().Stop();
				GetComponent<AudioSource>().volume = 0f;
				status = MusicPlayerStatus.Playing;
				
				// Is there another music to be played?
				if(nextclip != null)
				{
					GetComponent<AudioSource>().clip = nextclip;
					GetComponent<AudioSource>().Play();
					nextclip = null;
					fadeStart = Time.time;
					status = MusicPlayerStatus.FadingIn;
				}
			}
		}
		else if(status == MusicPlayerStatus.FadingIn)
		{
			if(Time.time < fadeStart+fadeIn)
			{
				GetComponent<AudioSource>().volume = cubicInOut(Time.time-fadeStart, 0f, volume, fadeIn);
			}
			else
			{
				// Effect is finished
				GetComponent<AudioSource>().volume = volume;
				status = MusicPlayerStatus.Playing;
			}
		}
	}
}
