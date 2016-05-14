using UnityEngine;
using System.Collections;

public class PowerUpCrateCollision : MonoBehaviour {


	void OnStart(){
		Random.seed = 100;
	}

	void OnTriggerEnter(Collider other){

		int powerUpToken = 4/*Random.Range (1,5)*/;

		if(other.gameObject.tag == "Weapon" || other.gameObject.tag == "PowerUpWeapon"){
			GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerPowerUpActivate> ().SetPowerUp (powerUpToken);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
