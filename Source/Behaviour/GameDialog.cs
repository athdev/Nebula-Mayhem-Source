using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameDialog : MonoBehaviour {

	// Use this for initialization
	private bool animate;
	private bool pin;
	private float anim_frame_time;
	private float anim_up_time;
	private float curr_time;
	private Text curr_text;
	private Outline curr_outline;


	void Start () {
		curr_text = gameObject.GetComponent<Text>();
		curr_outline = gameObject.GetComponent<Outline>();
		curr_text.enabled = false;
		animate = false;
		pin = false;
		anim_frame_time = 0.01f;
		anim_up_time = 3.0f;
		curr_time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if(animate && Time.time > curr_time+anim_frame_time ){
			gameObject.transform.localScale += new Vector3 (0.1f,0.1f,0.1f);
			curr_time = Time.time;
			if(gameObject.transform.localScale.x > 1.0f ){
				curr_time = Time.time;
				pin = true;
				animate = false;
			}
		}

		if(pin && Time.time > curr_time + anim_up_time){
			pin = false;
			curr_text.enabled = false;
		}



	}

	public void SpawnDialog(Color textColor, Color outlineColor,string text){

		curr_text.text = text;
		curr_text.color = textColor;
		curr_outline.effectColor = outlineColor;
		gameObject.transform.localScale = new Vector3 (0.0f,0.0f,0.0f);
		curr_text.enabled = true;
		animate = true;
	}
}
