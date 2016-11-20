using UnityEngine;
using System.Collections;

public class glow : MonoBehaviour {
	private SpriteRenderer s;
	public int anus = 0;
	public bool glowing = false;
	public float startTime;
	public float t;
	public float tid;
	float lengde = 1.0f;
	void Start () 
	{
		s = GetComponent<SpriteRenderer> ();
		startTime = Time.time;


	}
		
	IEnumerator flash(float time)
	{
		yield return new WaitForSeconds (time);
		s.color = Color.black;
		glowing = false;
	}

	void colourFade()
	{ 
		t = (Time.time - startTime) / lengde;
		s.color = new Color (Mathf.Lerp (60.0f/255.0f, 0f, t), Mathf.Lerp (200.0f/255.0f, 0f, t), Mathf.SmoothStep (200.0f/255.0f, 0f, t), 1.0f);
		StartCoroutine(flash(4.0f));
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


	void FixedUpdate () 
	{
		
		if(glowing == true)
		{
			colourFade ();
		}	
	}
}
