using UnityEngine;
using System.Collections;

public class AlphaSquadCreateMember : MonoBehaviour {

	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateSquadMember(){
		GameObject squadMember;
		squadMember = Instantiate (Resources.Load("PowerUps/AlphaSquadMember"),gameObject.transform.position,Quaternion.LookRotation(Vector3.forward)) as GameObject; 
	}
}
