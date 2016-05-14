using UnityEngine;
using System.Collections;

public class SpawnPowerUp : MonoBehaviour {

	public float [] rateRange = new float[2];
	private float spawnRate;
	public Transform destination;
	private float nextSpawn;
	private GameObject powerUpCrate;
	// Use this for initialization
	void Start () {
		spawnRate = Random.Range (rateRange[0],rateRange[1]);
		nextSpawn=spawnRate;
		Random.seed = 100;
	}

	// Update is called once per frame
	void Update () {

		if(Time.time > nextSpawn){
			spawnRate = Random.Range (rateRange[0],rateRange[1]);
			nextSpawn = Time.time + spawnRate;
			StopCoroutine("SpawnGiftCrate");//Failsafe
			StartCoroutine("SpawnGiftCrate");

		}


	}

	IEnumerator SpawnGiftCrate(){

		float probability = Random.Range (0.0f,100.0f);
		float spawnProbability = Random.Range (5.0f,30.0f);
		if (probability < spawnProbability) {
			powerUpCrate = Instantiate(Resources.Load ("PowerUps/PowerUpCrate"), gameObject.transform.position, Quaternion.identity) as GameObject;
			powerUpCrate.GetComponent<AsteroidMovement> ().target = destination;
			powerUpCrate.GetComponent<AsteroidMovement> ().enabled = true;
		} 

		yield return null;
	}
}
