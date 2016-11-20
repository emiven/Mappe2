using UnityEngine;
using System.Collections;

public class CharacterRotation : MonoBehaviour {

//	private CameraTargetController camTarget;
//
//	private Vector3 mousePos;
//	private Vector3 pivotPos;
//	public Vector3 fa;
//	public float deadzone = 0.25f;
//	public float satan;
//	public float angle;
//	public static bool JOYSTICK = true;
//	public static bool MOUSE = false;
//
//	// Use this for initialization
//	void Start () {
//		camTarget = FindObjectOfType<CameraTargetController> ();
//	}	
//
//	void rotasjon()
//	{
//		float joyVertical = Input.GetAxis ("rightJoystickVertical");
//		float joyHorizontal = Input.GetAxis ("rightJoystickHorizontal");
//
//
//		satan = Mathf.Atan2 (-joyVertical, joyHorizontal);
//		angle = satan * (180/Mathf.PI); 
//
//
//
//		fa = new Vector3( 0, 0,angle );
//		if(fa.magnitude < deadzone)
//		{
//			fa = Vector3.zero;
//		}
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		if (camTarget.inputType == MOUSE) {
//			//Mouse
//			mousePos = Input.mousePosition;
//			mousePos.z = 5f;
//
//			pivotPos = Camera.main.WorldToScreenPoint (transform.position);
//			mousePos.x -= pivotPos.x;
//			mousePos.y -= pivotPos.y;
//
//			angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;
//		} else {
//			rotasjon ();
//			transform.eulerAngles = fa;
//		}
//
//
//
//	}

	private CameraTargetController camTarget;

	private Vector3 mousePos;
	private Vector3 pivotPos;
	public float angle;

	public static bool JOYSTICK = true;
	public static bool MOUSE = false;

	// Use this for initialization
	void Start () {
		camTarget = FindObjectOfType<CameraTargetController> ();
	}	

	// Update is called once per frame
	void Update () {

		if (camTarget.inputType == MOUSE) 
		{
			//Mouse
			mousePos = Input.mousePosition;
			mousePos.z = 5f;

			pivotPos = Camera.main.WorldToScreenPoint (transform.position);
			mousePos.x -= pivotPos.x;
			mousePos.y -= pivotPos.y;

			angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		} else {

			//Controller
			float joyVertical = Input.GetAxis ("rightJoystickVertical");
			float joyHorizontal = Input.GetAxis ("rightJoystickHorizontal");

			angle = Mathf.Atan2 (-joyVertical, joyHorizontal) * Mathf.Rad2Deg;

		}

		transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle));

	}
}
