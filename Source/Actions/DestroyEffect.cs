using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {

	private ParticleSystem ps;
	void Start(){
		ps = gameObject.GetComponentInChildren<ParticleSystem>();
	}

	void Update ()
	{

		if(!ps.IsAlive()){
			Destroy(gameObject);
		}
	
	}
}
