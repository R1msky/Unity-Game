using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour {
		
	[SerializeField] private GameObject backGround;
	private SpriteRenderer bg;
	private float speed = 0.001F;
	private float r;
	private float g;
	private float b;
	private Color color;
	private Color originalColor;
	[SerializeField] private PauseButton _isPaused;
	[SerializeField] private LoseScript loseSript;

	public float getSpeed()
	{
		return speed;
	}

	public void setSpeed(float newSpeed)
	{
		speed = newSpeed;
	}

	void Start () {

		bg = backGround.GetComponent<SpriteRenderer> ();
		r = bg.color.r;
		g = bg.color.g;
		b = bg.color.b;
		originalColor = new Color (r, g, b);
	}

	void Update () {
		if(_isPaused.getIsPaused() == false && loseSript.getIsLosed() == false)
		ChangeColor ();
	}

	void ChangeColor()
	{
		if (g <= 0 && b <= 0) {
			loseSript.ShowLoseMenu ();
		} 
		else {
			g -= speed;
			b -= speed;
			color = new Color (r, g, b);
			bg.color = color;
		}
	}

	public void ReturnColor()
	{
		r = originalColor.r;
		g = originalColor.g;
		b = originalColor.b;
	}
}
