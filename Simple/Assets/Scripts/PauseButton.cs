using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

	private bool isPaused = false;
	[SerializeField] private GameObject panel;
	[SerializeField] private GameObject continueBttn;
	[SerializeField] private GameObject exitBttn;
	[SerializeField] private GameObject audioBttn;
	[SerializeField] private GameObject text;
	[SerializeField] private GameObject pauseInctv;
	[SerializeField] private AudioSource soundSource;
	[SerializeField] private AudioClip soundClip;

	public bool getIsPaused()
	{
		return isPaused;
	}

	void Start()
	{
		HideButtons ();
	}

	public void PauseButtonClick()
	{   
		if (!isPaused) {
			ShowButtons ();
			Time.timeScale = 0;

		} 
		else {
			HideButtons ();
			Time.timeScale = 1;
		}
		isPaused = !isPaused;
	}

	 void ShowButtons()
	{
		pauseInctv.SetActive(true);
		panel.SetActive(true);
		continueBttn.SetActive (true);
		exitBttn.SetActive (true);
		audioBttn.SetActive (true);
		text.SetActive (true);
	}

	void HideButtons()
	{
		pauseInctv.SetActive(false);
		continueBttn.SetActive (false);
		exitBttn.SetActive (false);
		audioBttn.SetActive (false);
		text.SetActive (false);
		panel.SetActive (false);
	}
		
	public void ContinueGame()
	{
		soundSource.PlayOneShot (soundClip);
		HideButtons ();
		Time.timeScale = 1;
	isPaused = !isPaused;
	}
}
