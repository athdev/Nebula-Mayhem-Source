using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	//Default Unity Collision function
	public GameObject shield;
	GameObject shield_indicator;

	void Start (){
		shield_indicator = GameObject.FindWithTag ("Shield");
	}


	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Asteroid"){
			StopAllCoroutines ();
			bool active_shield=shield_indicator.GetComponent<ShieldCalculation> ().CheckShield ();
			if(active_shield){
				StartCoroutine ("ActivateShield");
			}
			Destroy(other.gameObject);

		}
	}

	IEnumerator ActivateShield (){
		if(shield.gameObject.activeSelf!=true ){
			shield.SetActive (true);
			shield.GetComponent<ShieldOff>().SetCurrentTime(Time.time);
		}

		yield return null;
	}
}
