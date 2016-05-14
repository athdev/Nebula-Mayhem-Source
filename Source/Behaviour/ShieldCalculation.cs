using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShieldCalculation : MonoBehaviour {

	// Use this for initialization
	private int shield;
	void Start () {
		shield = 100;
		gameObject.GetComponent<Text>().text = shield.ToString ();
	}

	public void DecShield (int amount){
		shield -= amount;
		gameObject.GetComponent<Text>().text = shield.ToString ();
	}

	public void IncShield (int amount){
		shield += amount;
		if(shield > 100){
			shield = 100;
		}
		gameObject.GetComponent<Text>().text = shield.ToString ();
	}

	public bool CheckShield(){
		return (shield > 0);
	}

}


