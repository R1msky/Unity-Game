using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingFruit : MonoBehaviour {

	private float speedY;
	private float speedX;

	void Start()
	{
		speedY = Random.Range (0.5f, 1.2f);
		speedX = Random.Range (0.5f, 1.2f);
	}

	void Update () {
		transform.Translate (Time.deltaTime * speedX, Time.deltaTime * speedY, 0);
		if (transform.position.y > 1.5)
			speedY = -speedY;
		if (transform.position.y < 0.6)
			speedY = Random.Range (0.5f, 1.2f);
		if (transform.position.x > 0.8)
			speedX = -speedX;
		if (transform.position.x < -0.8)
			speedX = Random.Range (0.5f, 1.2f);
	}
}
