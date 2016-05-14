using UnityEngine;
using System.Collections;

public class PlayerPowerUpActivate : MonoBehaviour {


	public void SetPowerUp(int powerUp){
		switch (powerUp) {
		case 1:
			gameObject.GetComponentInChildren<LaserCannon> ().Activate ();
			GameObject.FindGameObjectWithTag ("GameDialog").GetComponent<GameDialog> ().SpawnDialog (Color.red,Color.blue,"Laser Cannon");
			break;
		case 2:
			GameObject.FindGameObjectWithTag ("Health").GetComponent<HealthCalculation> ().IncHealth (10);
			GameObject.FindGameObjectWithTag ("GameDialog").GetComponent<GameDialog> ().SpawnDialog (Color.green,Color.blue,"Health +10");
			break;
		case 3:
			GameObject.FindGameObjectWithTag ("Shield").GetComponent<ShieldCalculation> ().IncShield (10);
			GameObject.FindGameObjectWithTag ("GameDialog").GetComponent<GameDialog> ().SpawnDialog (Color.cyan,Color.red,"Shield +10");
			break;
		case 4:
			GameObject alphaSquad = Resources.Load("PowerUps/AlphaSquadPowerUp") as GameObject;
			Instantiate (alphaSquad,gameObject.transform.position,alphaSquad.transform.rotation);
			GameObject.FindGameObjectWithTag ("GameDialog").GetComponent<GameDialog> ().SpawnDialog (Color.red,Color.blue,"Alpha Squad");
			break;
		}
	}
}
