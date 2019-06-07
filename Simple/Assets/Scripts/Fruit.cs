using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public void fruitMovement(Vector3 target)
	{
		iTween.MoveTo (gameObject, iTween.Hash("x", target.x, "y", target.y,  "time", 0.5f));
		iTween.ScaleTo (gameObject, iTween.Hash("x", 0.2f, "y", 0.2f,  "time", 0.5f));
	}
}

