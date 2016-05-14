using UnityEngine;
using System.Collections;

public class SpawnBoss : MonoBehaviour {

	// Use this for initialization
	public float spawn_time;
	private GameObject asteroid;
	private Transform destination;
	private float time;

	void Start () {
		time = Time.time;
		destination = gameObject.GetComponent<SpawnAsteroid> ().destination;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > time+spawn_time ){
			asteroid = Instantiate (Resources.Load ("Asteroids/BossAsteroid"), gameObject.transform.position, Quaternion.identity) as GameObject;
			asteroid.GetComponent<AsteroidMovement> ().target = destination;
			asteroid.GetComponent<AsteroidMovement> ().enabled = true;
			time = Time.time;
		}
	}
}
