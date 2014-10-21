using UnityEngine;
using System.Collections;

public class Z_KickBall : MonoBehaviour {

	public Camera maincam;
	public int forcey;
	public int forcez;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void OnMouseDown(){

		gameObject.rigidbody.AddForce (0, forcey*1000, forcez*1000);
	}
}
