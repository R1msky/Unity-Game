using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnContoller : MonoBehaviour {

	[SerializeField] private List<GameObject> fruits = new List<GameObject> ();
	[SerializeField] private GameObject[] prefabs;
	private float offset = 1.5f;
	private float posY;
	private Fruit fruit;
	private GameObject currentFruit;

	void Start () {

		float scale = 0.5f;
		posY = gameObject.transform.position.y + 1.5f;
		for (int i = 0; i < 5; i++) {
			GameObject obj;
			obj = Instantiate (prefabs [Random.Range (0, prefabs.Length)]);
			posY -= offset;
			obj.transform.position = new Vector3 (0,posY,0);
			iTween.ScaleTo (obj, iTween.Hash ("x", scale, "y", scale, "time", 0.0f));
			fruits.Add (obj);
			scale += 0.3f;
		}
	}
	

	void Update () {

	}

	public void SpawnNewFruit()
	{

		GameObject objct;
		objct = Instantiate (prefabs [Random.Range (0, prefabs.Length)]);
		objct.transform.position = transform.position;
		fruits.Insert (0, objct);

	}

	public void translateFruits()
	{
		float Y;
		float scale = 0.8f;
		foreach (GameObject obj in fruits)
		{
			Y = obj.transform.position.y - 1.5f;
				iTween.MoveTo (obj, iTween.Hash ("y", Y, "time", 0.4f));
			iTween.ScaleTo (obj, iTween.Hash ("x", scale, "y", scale, "time", 0.5f));
			scale += 0.3f;
		}
	}

	public List<GameObject> getFruits()
	{
		return fruits;
	}
}
