using UnityEngine;
using System.Collections;

public class Z_timekill : MonoBehaviour {

	private float timer = 0.0f;


	// Use this for initialization
	void Start () {

		timer = 0f;

	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (timer >=6) {
			this.gameObject.guiText.text="";
		}
	
	}


}