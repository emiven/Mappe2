using UnityEngine;
using System.Collections;

public class DropScript : MonoBehaviour {
	private SpriteRenderer sRender;
	bool run = true;
	// Use this for initialization
	void Start () 
	{
		sRender = GetComponent<SpriteRenderer> ();

	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy (gameObject);
		}
	}
	IEnumerator flash(float time)
	{
		run = false;
		yield return new WaitForSeconds (time);
		sRender.color = Color.yellow;
		yield return new WaitForSeconds (time);
		sRender.color = Color.red;
		yield return new WaitForSeconds (time);
		sRender.color = Color.black;
		yield return new WaitForSeconds (time);
		sRender.color = Color.green;
		yield return new WaitForSeconds (time);
		sRender.color = Color.blue;
		run = true;
	}

	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate()
	{
		if(run == true)
		{
			StartCoroutine (flash (0.15f));
		}

	}
}
