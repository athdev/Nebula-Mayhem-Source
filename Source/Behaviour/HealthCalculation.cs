using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthCalculation : MonoBehaviour {

	// Use this for initialization
	private int health;
	void Start () {
		health = 100;
		gameObject.GetComponent<Text>().text = health.ToString ();
	}
	
	public void DecHealth (int amount){
		health -= amount;
		gameObject.GetComponent<Text>().text = health.ToString ();
		ChangeTextColor ();
	}

	public void IncHealth(int amount){
		health += amount;
		if(health > 100){
			health = 100;
		}
		gameObject.GetComponent<Text>().text = health.ToString ();
		ChangeTextColor ();
	}

	void ChangeTextColor (){
		if (health >= 80) {
			gameObject.GetComponent<Text> ().color = Color.green;
		} else if (health >= 40) {
			gameObject.GetComponent<Text> ().color = Color.yellow;
		} else if (health >= 0) {
			gameObject.GetComponent<Text> ().color = Color.red;
		}
	}
}
