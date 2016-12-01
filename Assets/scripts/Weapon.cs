using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	private characterMovement player;
	private characterMovement playernewangle;
	private GameObject newProjectile;
	public AudioMaster Pauido;
	public int whatsound;
	public float spread;
	public float angle;
	public float fireDelay;
	public float projectileLifetime;
	public float projectileSpeed;
    public int damage;
	public GameObject projectile;
	public Transform firePoint;
	public Transform firePoint2;
	public Transform firePoint3;
	public bool triplespray = false;
	public GameObject camera;

	private bool canFire;

	// Use this for initialization
	void Start () {
	//	angle = Mathf.Atan2 (player.transform.rotation.y,player.transform.rotation.x) * Mathf.Rad2Deg;
		canFire = true;
		player = FindObjectOfType<characterMovement> ();
        projectile.GetComponent<Projectile>().damage = damage;
	}

	// Update is called once per frame
	void Update () 
	{
		
		
	}

	public void fire(){
		if (canFire == false)
			return;
		
		if (triplespray == false) {
			Pauido.playsound (whatsound);
			newProjectile = Instantiate (projectile, firePoint.position, player.transform.rotation) as GameObject;
			camera.GetComponent<CameraShake>().ShakeCamera(0.1f, 0.01f);
		}
			
		else
		{
			Pauido.playsound (whatsound);
			newProjectile = Instantiate (projectile, firePoint.position, player.transform.rotation) as GameObject;
			Pauido.playsound (whatsound);
			newProjectile = Instantiate (projectile, firePoint2.position, player.transform.rotation) as GameObject;
			Pauido.playsound (whatsound);
			newProjectile = Instantiate (projectile, firePoint3.position, player.transform.rotation) as GameObject;
			camera.GetComponent<CameraShake>().ShakeCamera(1f, 0.01f);
		}
		StartCoroutine (Cooldown (fireDelay));
	}
    
    IEnumerator Cooldown(float fireDelay)
	{
		canFire = false;
		yield return new WaitForSeconds(fireDelay);
	
		canFire = true;
	}
}
