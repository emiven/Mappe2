using UnityEngine;
using System.Collections;

public class HealthDrop : MonoBehaviour {
	private SpriteRenderer sRender;
	private float t;
	float fadeTime = 0.09f;
	// Use this for initialization
	void Start () 
	{
		sRender = GetComponent<SpriteRenderer> ();
		sRender.color = Color.red;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy (gameObject);
		}
	}
	void colourFade()
	{ 
		t = Time.deltaTime* fadeTime;
		sRender.color = Color.Lerp (sRender.color, Color.gray, t);

	}

	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate()
	{
		colourFade ();

	}
}