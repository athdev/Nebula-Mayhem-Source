using UnityEngine;
using System.Collections;

public class AlphaSquadMoveToTarget : MonoBehaviour {

	// Use this for initialization
	public float speed;
	private bool moveOut;
	public Transform target;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!moveOut) {
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, target.transform.position, speed * Time.deltaTime);
			
		
		} else {
			gameObject.transform.Translate(Vector3.forward *speed * Time.deltaTime);
		}


	}

	public void ChangeCourse(){
		moveOut = true;
		gameObject.GetComponent<AlphaSquadLaserFire> ().enabled = false;
	}


}
