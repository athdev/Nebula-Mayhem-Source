using UnityEngine;
using System.Collections;

public class AlphaSquadLaserMovement : MonoBehaviour {

	public float speed;
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.forward * speed);
	}
}
