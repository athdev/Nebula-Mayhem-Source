using UnityEngine;
using System.Collections;

public class LaserCannon : MonoBehaviour {

	// Use this for initialization

	private float curr_time;
	public float uptime;
	private bool active;

	public Transform fire_origin;
	private GameObject player;

	void Start () {
		active = false;
		player = GameObject.FindGameObjectWithTag ("Player");
		gameObject.GetComponentsInChildren<Renderer>()[1].enabled = false;
	}

	void Update (){

		if(Time.time > curr_time + uptime && active){
			active = false;
			gameObject.GetComponent<Renderer> ().enabled = false;
			player.GetComponent<LaserFire> ().SetDefaultFireOrigin();
			player.GetComponent<LaserFire> ().SetDefaultFireSFX();
			player.GetComponent<LaserFire> ().SetDefaultLaserBeam();
		}else if(Time.time > curr_time +1.5f && active){
			gameObject.GetComponentsInChildren<Renderer>()[1].enabled = false;
			gameObject.GetComponent<Renderer>().enabled = true;
		}
	}

	public void Activate(){
		if (!active) {
			gameObject.GetComponent<Renderer> ().enabled = false;
			active = true;
			curr_time = Time.time;
			player.GetComponent<LaserFire> ().SetFireOrigin (fire_origin);
			player.GetComponent<LaserFire> ().SetFireSFX ("SFX/LaserCannonSFX");
			player.GetComponent<LaserFire> ().SetLaserBeam ("Weapons/LaserCannonBeam");
			gameObject.GetComponentsInChildren<Renderer> () [1].enabled = true;
			gameObject.GetComponent<AudioSource> ().Play ();
		} else {
			curr_time = Time.time;
			gameObject.GetComponentsInChildren<Renderer> () [1].enabled = true;
			gameObject.GetComponent<AudioSource> ().Play ();
		}

	}
		
		
}
