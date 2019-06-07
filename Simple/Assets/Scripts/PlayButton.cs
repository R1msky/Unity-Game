using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour {
	
	[SerializeField] private AudioSource soundSource;
	[SerializeField] private AudioClip soundClip;

	void Start()
	{

	}

	public void LoadGame()
	{
		
			soundSource.PlayOneShot (soundClip);
			SceneManager.LoadScene ("Game");
	}
}
