using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	[SerializeField] private Text scoreText;
	private int score;

	public int getScore()
	{
		return score;
	}

	void Start () {

		score = 0;
		scoreUpdate ();
	}


	void scoreUpdate()
	{
		scoreText.text = score.ToString();
	}

	public void AddScore()
	{
		score += 10;
		scoreUpdate ();
	}
}
