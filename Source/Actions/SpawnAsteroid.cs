using UnityEngine;
using System.Collections;

public class SpawnAsteroid : MonoBehaviour {

	public float [] rate_range = new float[2];
	private float spawn_rate;
	public Transform destination;
	private float next_spawn;
	private GameObject asteroid;
	// Use this for initialization
	void Start () {
		spawn_rate = Random.Range (rate_range[0],rate_range[1]);
		next_spawn=spawn_rate;
		Random.seed = 100;
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time > next_spawn){
			spawn_rate = Random.Range (rate_range[0],rate_range[1]);
			next_spawn = Time.time + spawn_rate;
			StopCoroutine("Spawn");
			StartCoroutine("Spawn");

		}


	}

	IEnumerator Spawn(){
		
		float asteroid_pick = Random.Range (0.0f,100.0f);
		if (asteroid_pick > 50.0f) {
			asteroid = Instantiate (Resources.Load ("Asteroids/Asteroid1"), gameObject.transform.position, Quaternion.identity) as GameObject;
		} else if(asteroid_pick > 20.0f && asteroid_pick < 50.0f) {
			asteroid = Instantiate (Resources.Load ("Asteroids/Asteroid2"), gameObject.transform.position, Quaternion.identity) as GameObject;
		}else if(asteroid_pick > 10.0f && asteroid_pick < 20.0f){
			asteroid = Instantiate (Resources.Load ("Asteroids/Asteroid3"), gameObject.transform.position, Quaternion.identity) as GameObject;
		}else if(asteroid_pick > 0.0f && asteroid_pick < 10.0f){
			asteroid = Instantiate (Resources.Load ("Asteroids/Asteroid4"), gameObject.transform.position, Quaternion.identity) as GameObject;
		}

		asteroid.GetComponent<AsteroidMovement> ().target = destination;
		asteroid.GetComponent<AsteroidMovement> ().enabled = true;
		yield return null;
	}
}
