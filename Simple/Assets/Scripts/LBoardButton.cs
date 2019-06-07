using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class LBoardButton : MonoBehaviour {

	private const string leaderboard = "CgkIxYfbt8IaEAIQAA";
	public GameObject panel;

	void Awake()
	{
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ().Build ();
		PlayGamesPlatform.InitializeInstance (config);
		PlayGamesPlatform.DebugLogEnabled = true;
         PlayGamesPlatform.Activate();
		Social.localUser.Authenticate ((bool success) => {

			//			if (success) {
			//				CheckAuthenticate();
			//				Debug.Log("Welocome, new user!");
			//			}
			//			else Debug.Log("Oops, i cant find the user");
		});

	
	}
	public void ShowLeaderBoard()
	{
		
		PlayGamesPlatform.Instance.ShowLeaderboardUI(leaderboard);
	}

	public void CheckAuthenticate()
	{
			panel.SetActive (true);
	
			
	}
}
