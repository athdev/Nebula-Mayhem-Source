using UnityEngine;
using System.Collections;

public class ShieldOff : MonoBehaviour {

	// Update is called once per frame
	private float curr_time;
	private float delay=0.7f;
	void Start(){
		curr_time = Time.time;
	}

	void Update () {
		
		if (Time.time > curr_time+delay) {
			gameObject.SetActive(false);
		}
	}

	public void SetCurrentTime(float time){
		curr_time=time;
	}
}
