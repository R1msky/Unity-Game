using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class ExitButton : MonoBehaviour {

	public void QuitFromGame()
	{
		Application.Quit();
		PlayGamesPlatform.Instance.SignOut ();
		Debug.Log ("Game was closed");
	}

}
