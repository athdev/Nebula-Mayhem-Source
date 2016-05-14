using UnityEngine;
using System.Collections;

public class AlphaSquadPowerUp : MonoBehaviour {

	// Use this for initialization
	public float ttl;
	private float currTime;
	private GameObject [] squadMembers;
	private bool disengage;

	void Start () {
		squadMembers = GameObject.FindGameObjectsWithTag ("AlphaSquadMember");
		currTime = Time.time;
		disengage = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > currTime+(ttl-2.0f) && disengage == false){
			gameObject.GetComponentInChildren<AsteroidRotation> ().enabled = false;
			for(int i=0; i < 4 ;i++){
				squadMembers[i].GetComponent<AlphaSquadMoveToTarget>().ChangeCourse();

			}
			disengage = true;
		}else if(Time.time > currTime+ttl){
			Destroy (gameObject);
		}
			

	}
		
}
