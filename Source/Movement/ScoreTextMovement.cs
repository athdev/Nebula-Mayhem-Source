using UnityEngine;
using System.Collections;

public class ScoreTextMovement : MonoBehaviour {

	// Use this for initialization
	private float curr_time;
	private float ttl=2.0f;
	void Start () {
	
		curr_time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Translate (Vector3.up * 0.04f,Space.World);
		if(Time.time > (curr_time+ttl)){
			Destroy (gameObject);
		}
	
	}
}
