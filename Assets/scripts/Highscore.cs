using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
	public int HighScore = 0; 
	Text txt;
	public Points p;

	void Start () 
	{
		txt = gameObject.GetComponent<Text>();
		txt.text = "Highscore : " + HighScore;
		if(PlayerPrefs.HasKey ("HighScore")){
			HighScore = PlayerPrefs.GetInt ("HighScore");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Highscore : " + HighScore;
	
	}
}
