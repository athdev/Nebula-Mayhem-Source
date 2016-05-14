using UnityEngine;
using System.Collections;

public class AsteroidCollision : MonoBehaviour {

	public int health;
	public int score_amount;
	public GameObject pointIndicator;

	//Default Unity Collision function
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag == "Weapon" || other.gameObject.tag == "PowerUpWeapon"){
			int dmg = other.gameObject.GetComponent<WeaponCharacteristics> ().GetDamage ();
			health -= dmg;
			if(health <= 0){
				Instantiate(Resources.Load("FX/Explosion_Big"),gameObject.transform.position,Quaternion.identity);
				Instantiate(Resources.Load("FX/AsteroidExplosion_Big"),gameObject.transform.position,Quaternion.identity);
				Instantiate(pointIndicator,gameObject.transform.position,Quaternion.identity);
				GameObject.FindGameObjectWithTag ("Score").GetComponent<ScoreCalculation> ().SetScore (score_amount);
				Destroy(gameObject);
			}
			Destroy(other.gameObject);
		}else if(other.gameObject.tag == "Player"){
			Instantiate(Resources.Load("FX/Explosion_Big"),gameObject.transform.position,Quaternion.identity);
			Instantiate(Resources.Load("FX/AsteroidExplosion_Big"),gameObject.transform.position,Quaternion.identity);
			GameObject shield = GameObject.FindGameObjectWithTag ("Shield");
			if (shield.GetComponent<ShieldCalculation> ().CheckShield ()) {
				shield.GetComponent<ShieldCalculation> ().DecShield (20);
			} else {
				GameObject.FindGameObjectWithTag ("Health").GetComponent<HealthCalculation> ().DecHealth (25);
			}
			Destroy(gameObject);
		}else if(other.tag=="AlphaSquadMember"){
			Instantiate(Resources.Load("FX/Explosion_Big"),gameObject.transform.position,Quaternion.identity);
			Instantiate(Resources.Load("FX/AsteroidExplosion_Big"),gameObject.transform.position,Quaternion.identity);
			Instantiate(pointIndicator,gameObject.transform.position,Quaternion.identity);
			GameObject.FindGameObjectWithTag ("Score").GetComponent<ScoreCalculation> ().SetScore (score_amount);
			Destroy (gameObject);
		}
	}
}
