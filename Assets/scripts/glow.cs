using UnityEngine;
using System.Collections;

public class glow : MonoBehaviour {

	public SpriteRenderer tiles;
	public bool fading = false;
	private float startTime;
	private float t;
	float fadeTime = 1.0f;
	void Start () 
	{
		startTime = Time.time;




	}

		
	IEnumerator flash(float time)
	{
		yield return new WaitForSeconds (time);

	}
	void colourChange()
	{
		tiles.color = new Color (60.0f/255.0f, 200.0f/255.0f,200.0f/255.0f, 1.0f);
	}

	void colourFade()
	{ 
		t = Time.deltaTime* fadeTime;
		tiles.color = Color.Lerp (tiles.color, Color.black, t);
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "tile")
		{
			tiles = other.GetComponent<SpriteRenderer>();
			colourChange ();
			 

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == "tile")
		{
			fading = true;
			StartCoroutine(flash(4.0f));
		}
	}
		


	void Update () 
	{
		if(fading == true)
		{
			colourFade ();
		}
	}
}
