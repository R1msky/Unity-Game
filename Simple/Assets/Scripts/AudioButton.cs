using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour {
	
	[SerializeField] private AudioSource soundSource;
	[SerializeField] private GameObject audioInctv;
	private static bool isPresed = false;

	void Start()
	{
		if (isPresed == false) {
			HideInctvBttn ();
			soundSource.mute = false;
		}

		else 
		{
			soundSource.mute = true;
		}
	}

	public void AudioController()
	{
		isPresed = !isPresed;
		soundSource.mute = !soundSource.mute;
		if (isPresed == true) 
		{
			ShowInctvBttn ();
		}

		else 
		{
			HideInctvBttn ();
		}
	}

	void HideInctvBttn()
	{
		audioInctv.SetActive (false);
	}

	void ShowInctvBttn()
	{
		audioInctv.SetActive (true);
	}

}
