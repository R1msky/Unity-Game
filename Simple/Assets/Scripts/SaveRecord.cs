using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class SaveRecord : MonoBehaviour {

	private const string leaderboard = "CgkIxYfbt8IaEAIQAA";
	private int record = 0;
	[SerializeField] private ScoreCounter _score;

		
	void Start()
	{
		


	}

	void Update () 
	{
		if (_score.getScore () > record) {
			PlayerPrefs.SetInt ("saverecord", _score.getScore ());
			PlayerPrefs.Save ();
			if (Social.localUser.authenticated) {
				Social.ReportScore (record, leaderboard, (bool success) => {
					if (success)
						Debug.Log ("Setted a new record: " + record);
					else
						Debug.Log ("error");
				});
			}
		}
			record = PlayerPrefs.GetInt ("saverecord");

	}

	public int getRecord()
	{
		return record;
	}


}
