using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTutor : MonoBehaviour {

	// Use this for initialization
	private TutorSpawnController Fruits;
	private GameObject fruit;
	private Fruit movement;
	public int index;
	public GameObject currentObj;
	private ScoreCounter scoreCounter;
	//[SerializeField] private Camera _camera;
	private TutorTimeController timeController;
	private float r;
	private float g;
	private float b;
	private float speed;
	private LoseScript loseSript;
	private PauseButton pauseButton;
	[SerializeField] private AudioClip audioClip;
	[SerializeField] private AudioSource audioSource;
	int count = 0;


	public GameObject getCurrent()
	{
		return currentObj;
	}

	public void setCurrent(GameObject newObj)
	{
		currentObj = newObj;
	}


	void Start()
	{
//		loseSript = GameObject.Find ("LoseSceneController").GetComponent<LoseScript> ();
		//originalColor = Camera.main.backgroundColor;
		//scoreCounter = GameObject.Find ("ScoreCounter").GetComponent<ScoreCounter> ();
		Fruits = GameObject.Find("SpawnController").GetComponent<TutorSpawnController> ();
		timeController = GameObject.Find("SpawnController").GetComponent<TutorTimeController> ();
		//pauseButton = GameObject.Find ("UIController").GetComponent<PauseButton> ();
	}

	void OnMouseDown()
	{
		//if (pauseButton.getIsPaused () == false) {
			fruit = GetNearestBall (Fruits.getFruits ());
			currentObj = fruit;
			movement = fruit.GetComponent<Fruit> ();
			movement.fruitMovement (gameObject.transform.position);
		//}
	}

	private GameObject GetNearestBall(List<GameObject> balls)
	{
		GameObject Nearest = balls[0];
		float ShorterDistance = Vector2.Distance (balls [0].transform.position, transform.position);
		foreach (GameObject obj in balls) {
			float Distance = Vector2.Distance (obj.transform.position, transform.position);
			if (Distance <= ShorterDistance) {
				Nearest = obj;
				index = balls.IndexOf (obj);
				ShorterDistance = Distance;
			}
		}
		return Nearest;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == gameObject.name) 
		{
			//audioSource.PlayOneShot (audioClip);
			count++;
			timeController.ReturnColor ();
			Fruits.getFruits ().Remove (fruit.gameObject);
			Destroy (fruit);
			scoreCounter.AddScore ();
			fruit = null;
			Fruits.translateFruits ();
			Fruits.SpawnNewFruit ();
			if (count == 10) 
			{
				speed = timeController.getSpeed () + 0.005f;
				timeController.setSpeed (speed);
				count = 0;
			}
		}
		//else 
		//{
		//	loseSript.ShowLoseMenu();
		//}
	}
}
