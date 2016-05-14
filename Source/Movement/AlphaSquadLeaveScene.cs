using UnityEngine;
using System.Collections;

public class AlphaSquadLeaveScene : MonoBehaviour {

	public float speed;
	public Transform origin;
	private float currTime;
	private float ttl;
	private bool moveOut;

	// Use this for initialization
	void Start () {
		moveOut = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > currTime + ttl && moveOut){
			moveOut = false;
			gameObject.transform.position = origin.position;
			//gameObject.GetComponentInParent<AlphaSquadPowerUp>().ReportPosition();
		}

		if (moveOut) {
			gameObject.transform.Translate (Vector3.forward * speed);
		}
	}

	public void Disengage(){
		currTime = Time.time;
		moveOut = true;
	}
}
