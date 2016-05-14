using UnityEngine;
using System.Collections;

public class PowerUpMovement : MonoBehaviour {

	// Use this for initialization

	private Transform destination;
	public float speed;
	void Start () {

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		destination = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position,destination.position,speed);
	}
}
