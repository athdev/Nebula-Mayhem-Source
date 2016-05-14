using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour {

	public float speed;
	private Transform target;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position,target.position,speed);
	}

	public void SetTarget(Transform newTarget){

		target = newTarget;
	}
}
