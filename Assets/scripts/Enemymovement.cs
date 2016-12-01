using UnityEngine;
using System.Collections;

public class Enemymovement : MonoBehaviour {
	GameObject Paudio;
	private GameObject spiller;
	private GameObject fiende;
	public Rigidbody rb;
	private SpriteRenderer sRendrer;
	private GameObject scRendrer;
    public Transform enemylazerprefab;
	public Transform drop;
	public Transform kami;
	public Transform healthdrop;
	private float a;
	private float b;
	private float r;
	public float k;
	public float t;
	public float f;
	public bool isGiant = false;
	private float angle;
	public float fart;
	public float amp;
	public Vector3 dist;
	public Vector3 Rad;
	public float disty;
	public int v;
    public int maxHealth = 100;
    public int health;
	public float startTime;

    float randomrotation;
	Vector3 target;
	public Points p;

	void Start () {
		Paudio = GameObject.Find ("AudioPlayer");
		sRendrer = GetComponent<SpriteRenderer> ();
		startTime = Time.time;
		//StartCoroutine(Shoot(k));
		 v = Random.Range(0, 16);
        health = maxHealth;
		k = Random.Range(2.0f, 4.0f);
		r = Random.Range(3.0f, 7.0f);
        randomrotation = Random.Range(-10f, 10f);
        spiller = GameObject.FindGameObjectWithTag("Player");
		fiende = GameObject.FindGameObjectWithTag("enemy");
		colourChanger ();
	}
	void anticipation()
	{
		f = Mathf.SmoothStep (0.055f, 0.0f, t);
		t = (Time.time - startTime) / k;
		scRendrer.transform.localScale = new Vector3 (f, 0.06f,0.06f);
	}
	void rotation()
	{
		target = spiller.transform.position - transform.position;
		angle = Mathf.Atan2 (target.y, target.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		
	}
	IEnumerator flash(float time)
	{
		yield return new WaitForSeconds (time);
		colourChanger ();
	
	}
	void colourChanger()
	{
		if (isGiant == false) {
			if (health >= 150) {
				sRendrer.color = Color.red;
			}
			if (health < 150 && health >= 100) {
				sRendrer.color = new Color (160.0f / 255.0f, 55.0f / 255.0f, 55.0f / 255.0f, 1f);
			} else if (health < 100) {
				sRendrer.color = new Color (160.0f / 255.0f, 55.0f / 255.0f, 55.0f / 255.0f, 100.0f / 255.0f);
			}
		}else{
			if (health >= 3500) {
				sRendrer.color = Color.yellow;
			}
			if (health < 3500 && health >= 1500) {
				sRendrer.color = new Color (250.0f / 255.0f, 250.0f / 255.0f, 190.0f / 255.0f, 1f);
			} else if (health < 1500) {
				sRendrer.color = new Color (250.0f / 255.0f, 250.0f / 255.0f, 190.0f / 255.0f, 100.0f / 255.0f);
			}
		}
		
	}
	void distfinder() //finner distanse mellom spiller og enemy
	{

			dist = spiller.transform.position - transform.position;
	}
	void moveTowards()
	{
		gameObject.transform.position = Vector2.MoveTowards (gameObject.transform.position, spiller.transform.position , Time.deltaTime * fart);
	}
    void moveAway()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, spiller.transform.position, Time.deltaTime * -fart/2);
    }
	void dropSpawn()
	{
		if(v == 10)
		{
			Instantiate(drop, transform.position, transform.rotation);
		}
		if(v == 4)
		{
			Instantiate(healthdrop, transform.position, transform.rotation);
		}
		
	}
	void rotateAroundPlayer()
	{
		if (randomrotation > 0)
			transform.RotateAround(spiller.transform.position, Vector3.forward, 5 * r * Time.deltaTime);
		else
			transform.RotateAround(spiller.transform.position, Vector3.back, 5 * r * Time.deltaTime);
	}
	// Update is called once per frame

	void FixedUpdate()
	{
		scRendrer = GameObject.FindGameObjectWithTag("Pointer");
		//anticipation ();
		rotation ();
        if (health <= 0)
        {
			dropSpawn ();
			//p.score++;
            Destroy(gameObject);
        }
        rotateAroundPlayer ();
        a = 3f;
		b = 1f;
		amp = (a* Mathf.Log(b*(dist.magnitude + 1f)))/2;

		if (dist.magnitude >= 10.0f) {
			fart = 2.0f;
		}
		else 
		{
			fart = 0.1f + amp;
			fart = Mathf.Clamp (fart, 0.0f, 4f);
		}
		distfinder ();
		if (dist.magnitude >= r) { //stopper å bevege seg mot spiller når den er innenfor en viss distanse
			moveTowards ();

		} else if (dist.magnitude < (r - 1f)) {
			moveAway ();

} 
		//else if (edist.magnitude < (1f)) {
//			keepDistance ();
//		}

	}
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "lazer")
        {
            sRendrer.color = Color.white;
			Paudio.GetComponent<AudioMaster>().playsound (1);
            StartCoroutine(flash(0.2f));
        }
    }
//	IEnumerator Shoot(float WaitTime)
//	{
//		if (Health.playerHealth != 0)
//		if (isGiant == true) {	
//			Instantiate (kami, transform.position, transform.rotation);
//		}else{Instantiate(enemylazerprefab, transform.position, transform.rotation);
//		}
//		yield return new WaitForSeconds(WaitTime);
//		StartCoroutine(Shoot(r));
//
//	}

	
}
