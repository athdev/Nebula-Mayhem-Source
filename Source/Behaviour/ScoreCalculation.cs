using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCalculation : MonoBehaviour {

	// Use this for initialization
	private int score;
	void Start () {
		score = 0;
		gameObject.GetComponent<Text>().text = score.ToString ();
	}

	public void SetScore (int amount){
		score += amount;
		gameObject.GetComponent<Text>().text = score.ToString ();
	}

	public int GetScore (){
		return score;
	}
}
