using UnityEngine;
using System.Collections;

public class LaserFire : MonoBehaviour {
	
	// Script that describes the points (or touch) n' click laser behaviour for the spaceship.
	//Origin of the laser bolt
	public Transform fireOrigin;
	//The default origin keeps the initial laser bolt origin in order to be used in different laser buff which may change the origin of the laswer fire.
	private Transform defaultOrigin;
	//Default sound effect for the laser fire.
	private AudioClip defaultSFX;
	private AudioSource audioSource;
	private GameObject laserBeam;
	//The default laswer bolt of the player.
	private GameObject defaultBeam;

	void Start () {
		//Initilization
		defaultOrigin = fireOrigin;
		defaultSFX = Resources.Load ("SFX/DefaultLaserSFX") as AudioClip;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = defaultSFX;
		laserBeam = Resources.Load ("Weapons/LaserBeam") as GameObject;
		defaultBeam = laserBeam;
	}
	
	// Update is called once per frame
	void Update () {
		//Coroutine usge for more control over the update for future multitouch or multibuff environment. 
		if(Input.GetButtonDown("Fire1")){
			//StopCoroutine("RotateAndFire"); //failsafe
			StartCoroutine("RotateAndFire");
		}

	}

	//Basic laser fire script.
	IEnumerator RotateAndFire(){
		int laserBoltNumber;
		while(Input.GetButtonDown("Fire1")){
			laserBoltNumber = GameObject.FindGameObjectsWithTag ("Weapon").Length;
			if(laserBoltNumber < 1){	
				RaycastHit hit= new RaycastHit();
				Ray hray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(Physics.Raycast(hray, out hit, 1000) && hit.collider.tag == "Asteroid"){
					gameObject.transform.LookAt(hit.transform);
					//Instantiate beam and target.
					GameObject beam=Instantiate(laserBeam,fireOrigin.position,Quaternion.LookRotation(fireOrigin.transform.forward)) as GameObject;
					beam.GetComponent<LaserMovement> ().SetTarget (hit.transform);
					beam.GetComponent<LaserMovement>().enabled=true;
					audioSource.Play ();
				}
			}

			yield return null;
		}


	}


	//Fire and origin set functions for different laser buff & effects control.
	public void SetFireOrigin(Transform newOrigin)
	{
		fireOrigin = newOrigin;
	}

	public void SetDefaultFireOrigin(){
		fireOrigin = defaultOrigin;
	}

	public void SetFireSFX(string file)
	{
		AudioClip newSFX = Resources.Load (file) as AudioClip;
		audioSource.clip = newSFX;
		
	}

	public void SetDefaultFireSFX(){
		audioSource.clip = defaultSFX;
	}

	public void SetLaserBeam(string file){
		GameObject newBeam = Resources.Load (file) as GameObject;
		laserBeam = newBeam;
	}

	public void SetDefaultLaserBeam(){
		laserBeam = defaultBeam;
	}


}

