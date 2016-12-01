using UnityEngine;
using System.Collections;

public class AudioMaster : MonoBehaviour {
	public AudioClip gethit;
	public AudioClip gethit2;
	public AudioClip healthdrop;
	public AudioClip drop;
	public AudioClip shootSpray;
	public AudioClip shootrifle;
	public AudioClip flamethrower;
	private AudioSource source;

	public void playsound(int nmr)
	{
		int ja = nmr;
		switch(ja)
		{
		case 1:
			source.PlayOneShot (gethit, 0.05f);
			break;
		case 2:
			source.PlayOneShot (healthdrop, 0.2f);
			break;
		case 3:
			source.PlayOneShot (shootSpray, 0.5f);
			break;
		case 4:
			source.PlayOneShot (flamethrower, 1.0f);
//			if (Input.GetKey (KeyCode.Mouse0) || Input.GetAxis ("rightJoystickVertical") != 0f || Input.GetAxis ("rightJoystickHorizontal") != 0f) 
//			{
//				if (!source.isPlaying) 
//				{
//					source.PlayOneShot (flamethrower, 1.0f);
//					//source.Play ();
//				}
//			}else{
//				source.Stop ();
//			}
			break;
		case 5:
			source.PlayOneShot (gethit2, 1.0f);
			break;
		case 6:
			source.PlayOneShot (drop, 1.0f);
			break;
		case 7:
			source.PlayOneShot (shootrifle, 0.5f);
			break;
			
		default:
			break;
				


		}
	}
	void Start () 
	{
		source = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
