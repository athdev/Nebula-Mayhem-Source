using UnityEngine;
using System.Collections;

public class NegateParentRotation : MonoBehaviour {

	// Use this for initialization
	private Transform defaultTransform;
	void Start () {
		defaultTransform= gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = defaultTransform.rotation;
	}
}
