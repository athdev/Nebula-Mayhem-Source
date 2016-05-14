using UnityEngine;
using System.Collections;

public class AsteroidRotation : MonoBehaviour {
	public float rotation_speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward,rotation_speed,Space.Self);
	}
}
