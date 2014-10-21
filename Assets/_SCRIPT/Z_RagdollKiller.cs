using UnityEngine;
using System.Collections;

public class Z_RagdollKiller : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {

		anim = gameObject.GetComponentInParent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision thing){

		if(thing.gameObject.tag =="ball"){
			print (thing.gameObject.name+" hit me");
			anim.enabled=false;
		}
	}

	IEnumerator OnCollisionExit(Collision thing){

		if(thing.gameObject.tag =="ball"){
			yield return new WaitForSeconds(1);
			anim.enabled=true;
		}
	}
}
