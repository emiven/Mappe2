using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    Text txt;
	public int score;
	public int HighScore = 0; 
	// Use this for initialization
	void Start () {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score : " + score;
		if (PlayerPrefs.HasKey ("score")) 
		{
			if (Application.loadedLevel == 0) {
				PlayerPrefs.DeleteKey ("score");
				score = 0;
			} else {
				score = PlayerPrefs.GetInt ("score");
			}
		}
    }
	
	// Update is called once per frame
	void Update () {
        txt.text = "Score : " + score;
    }
}
