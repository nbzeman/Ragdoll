using UnityEngine;
using System.Collections;

public class Z_SwitchRagdoll : MonoBehaviour {

	public bool kinToggle;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){

		if(col.gameObject.tag == "target"){
			print("target");

		}
	}
}
