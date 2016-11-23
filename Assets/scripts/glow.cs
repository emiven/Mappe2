using UnityEngine;
using System.Collections;

public class glow : MonoBehaviour {
	private SpriteRenderer s;
	public bool fading = false;
	private float startTime;
	private float t;
	float fadeTime = 4.0f;
	void Start () 
	{
		s = GetComponent<SpriteRenderer> ();
		startTime = Time.time;
		s.color = Color.black;


	}
		
	IEnumerator flash(float time)
	{
		yield return new WaitForSeconds (time);

	}
	void colourChange()
	{
		s.color = new Color (60.0f/255.0f, 200.0f/255.0f,200.0f/255.0f, 1.0f);
	}

	void colourFade()
	{ 
		t = (Time.time - startTime) / fadeTime;
		s.color = new Color (Mathf.SmoothStep (60.0f/255.0f, 0f, t), Mathf.SmoothStep (200.0f/255.0f, 0f, t), Mathf.SmoothStep (200.0f/255.0f, 0f, t), 1.0f);
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			colourChange ();

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
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
