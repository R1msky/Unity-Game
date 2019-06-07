using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionLogger : MonoBehaviour {

	private System.IO.StreamWriter sw;
	private string LogFileName = "log.txt";
	void Start () {
		DontDestroyOnLoad (gameObject);
		sw = new System.IO.StreamWriter (Application.persistentDataPath + "/" + LogFileName);
		Debug.Log (Application.persistentDataPath);

	}

	void OnEnable()
	{
		Application.RegisterLogCallback (HandleLog);
	}

	void OnDisable()
	{
		Application.RegisterLogCallback (null);
	}

	void HandleLog(string logString, string stackTrace, LogType type)
	{
		if (type == LogType.Exception || type == LogType.Error) {
			sw.WriteLine ("Logged at:" + System.DateTime.Now.ToString() + " - Log Desc: " + logString + " - Trace: " + stackTrace + " - Type: " + type.ToString());
		}
	}
	
	void OnDestroy()
	{
		sw.Close ();
	}
}
