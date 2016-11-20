using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	private characterMovement player;
	private GameObject newProjectile;
	public AudioClip shootSpray;
	private AudioSource source;
	public float spread;
	public float fireDelay;
	public float projectileLifetime;
	public float projectileSpeed;
    public int damage;
	public GameObject projectile;
	public Transform firePoint;

	private bool canFire;

	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource>();
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
		source.PlayOneShot (shootSpray, 1f);
		newProjectile = Instantiate (projectile, firePoint.position, player.transform.rotation) as GameObject;
		StartCoroutine (Cooldown (fireDelay));
	}
    
    IEnumerator Cooldown(float fireDelay)
	{
		canFire = false;
		yield return new WaitForSeconds(fireDelay);
		canFire = true;
	}
}
