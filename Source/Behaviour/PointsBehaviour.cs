using UnityEngine;
using System.Collections;

public class PointsBehaviour : MonoBehaviour {


	public void SetPoints(string filename){
		gameObject.GetComponent<SpriteRenderer>().sprite=Resources.Load<Sprite>(filename);
	}

}
