using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {
	public float rotation_speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up,rotation_speed,Space.Self);
	}
}
