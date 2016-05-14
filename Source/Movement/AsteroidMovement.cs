using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour {

	public float speed;
	public Transform target;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,target.position,speed);
		if(gameObject.transform.position == target.position){
			Destroy(gameObject);
		}
	}
}
