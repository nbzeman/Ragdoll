using UnityEngine;
using System.Collections;

public class ScoreTextScript : MonoBehaviour {
	
	public float fadeTime=1.0f;
	float startTime=0;
	
	// Use this for initialization
	void Start () {
		startTime=Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		//Make the text move upwards
		transform.Translate(0,Time.deltaTime*1.0f,0);
		
		//Compute and set the alpha value
		float newAlpha=1.0f-(Time.time-startTime)/fadeTime;
		GetComponent<TextMesh>().color=new Color(1,1,1,newAlpha);
		
		//If alpha has decreased to zero, destroy this game object
		if (newAlpha<=0)
		{
			Destroy(gameObject);
		}
	}
}
