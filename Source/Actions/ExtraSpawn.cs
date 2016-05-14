using UnityEngine;
using System.Collections;

public class ExtraSpawn : MonoBehaviour {

	public GameObject extra_object;
	private bool isQuiting = false;

	void OnApplicationQuit (){
		isQuiting = true;	
	}

	void OnDestroy()
	{
		if (!isQuiting) {
			GameObject new_object=Instantiate (extra_object, gameObject.transform.position, Quaternion.identity) as GameObject;
			new_object.GetComponent<AsteroidMovement> ().enabled = true;
			new_object.GetComponent<AsteroidMovement> ().target = gameObject.GetComponent<AsteroidMovement> ().target;

		}
	}
}
