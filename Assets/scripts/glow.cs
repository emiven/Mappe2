using UnityEngine;
using System.Collections;

public class glow : MonoBehaviour {
	private SpriteRenderer s;
	public int anus = 0;
	public bool glowing = false;
	private float startTime;
	public float lengde = 1.0f;
	void Start () 
	{
		s = GetComponent<SpriteRenderer> ();
		startTime = Time.time;
	

	}
		

	void colourFade()
	{
		float t = (Time.time - startTime) / lengde;
		s.color = new Color (Mathf.SmoothStep (60.0f/255.0f, 0f, t), Mathf.SmoothStep (200.0f/255.0f, 0f, t), Mathf.SmoothStep (200.0f/255.0f, 0f, t), 1.0f);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			glowing = true;

		}
	}
//	void OnTriggerExit2D(Collider2D other)
//	{
//		if(other.gameObject.tag == "Player")
//		{
//			glowing = true;
//		}
//	}


	void Update () 
	{
		if(glowing == true)
		{
			colourFade ();
		}	
	}
}
