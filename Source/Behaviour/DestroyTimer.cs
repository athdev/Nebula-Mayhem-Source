using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour {

	public float ttl;
	private float currTime;
	// Use this for initialization
	void Start () {
		currTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time> currTime+ttl){
			Destroy (gameObject);
		}
	}
}
