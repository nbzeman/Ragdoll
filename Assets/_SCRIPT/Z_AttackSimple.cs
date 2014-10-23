using UnityEngine;
using System.Collections;

public class Z_AttackSimple : MonoBehaviour {

	public Animator anim;
	AnimatorStateInfo stateInfo;
	
	//if we're in "Run" mode, respond to input for jump, and set the Jump parameter accordingly. 
	//if(stateInfo.nameHash == Animator.StringToHash("Base Layer.RunBT"))

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {



				if (Input.GetKeyDown ("p")) {
						anim.SetTrigger ("Punch");
				}
				if (Input.GetKey ("g")) {
						anim.SetBool ("Grab", true);
				} else {
						anim.SetBool ("Grab", false);
				}
		}
}