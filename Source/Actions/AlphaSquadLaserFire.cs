using UnityEngine;
using System.Collections;

public class AlphaSquadLaserFire : MonoBehaviour {

	// Script that describes the points (or touch) n' click laser behaviour for the spaceship.
	//Origin of the laser bolt
	public Transform fireOrigin;

	public float squadFireRate;

	private GameObject laserBeam;

	private float curr_time;
	private AudioSource audioSource;


	void Start () {
		//Initilization
		laserBeam = Resources.Load ("Weapons/AlphaSquadLaserBeam") as GameObject;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip=Resources.Load ("SFX/AlphaSquadLaserSFX") as AudioClip;

	}

	// Update is called once per frame
	void Update () {
		//Coroutine usge for more control over the update for future multitouch or multibuff environment. 
		if(Time.time - curr_time > squadFireRate){
			//StopCoroutine("RotateAndFire"); //failsafe
			StartCoroutine("AlphaSquadFire");
			curr_time = Time.time;
		}

	}

	//Basic laser fire script.
	IEnumerator AlphaSquadFire(){
			//Instantiate beam and target.
			GameObject beam=Instantiate(laserBeam,fireOrigin.position,Quaternion.LookRotation(fireOrigin.transform.forward)) as GameObject;
			if (!audioSource.isPlaying) {
				audioSource.Play ();
			}
			yield return null;
		}





}
