using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class LoseScript : MonoBehaviour {

	private bool isLosed = false;
	[SerializeField] private GameObject canvas;
	[SerializeField] private GameObject pauseBttn;
	[SerializeField] private GameObject scoreText;
	[SerializeField] private Text Score;
	[SerializeField] private Text TotalScore;
	[SerializeField] private AudioSource soundSource;
	[SerializeField] private AudioClip soundClip1;
	[SerializeField] private AudioClip soundClip2;
	private ScoreCounter _score;
	private SaveRecord _record;

	private static int count = 0;

	private InterstitialAd interstitial;

	public bool getIsLosed()
	{
		return isLosed;
	}
		
		

	void Start () {
		Debug.Log (count);
		_score = GameObject.Find ("ScoreCounter").GetComponent<ScoreCounter> ();
		_record = GameObject.Find ("SceneController").GetComponent<SaveRecord> ();
		canvas.SetActive (false);

	}
		
	public void ShowLoseMenu()
	{


		isLosed = true;
		soundSource.PlayOneShot (soundClip1);
		canvas.SetActive (true);
		pauseBttn.SetActive(false);
		scoreText.SetActive(false);
		ShowResult ();
		Time.timeScale = 0;
	}

	void ShowResult()
	{
		Debug.Log (_record.getRecord());
		Score.text = "Score: " + _score.getScore().ToString ();
		TotalScore.text = "Best Score: " + _record.getRecord().ToString ();
	}

	public void TryAgain()
	{
		soundSource.PlayOneShot (soundClip2);
		Time.timeScale = 1;
		SceneManager.LoadScene ("Game");
	}


}
