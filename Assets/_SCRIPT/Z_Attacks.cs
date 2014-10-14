using UnityEngine;
using System.Collections;

public class Z_Attacks : MonoBehaviour {

	public Animator anim;
	public static bool grapple = false;
	public Transform grappleTarget;
	public float distance;
	public float d = 1;
	AnimatorStateInfo stateInfo;
	
	//if we're in "Run" mode, respond to input for jump, and set the Jump parameter accordingly. 
	//if(stateInfo.nameHash == Animator.StringToHash("Base Layer.RunBT"))

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		stateInfo = anim.GetCurrentAnimatorStateInfo(0);
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance (transform.position, grappleTarget.position);


		if(Input.GetKeyDown("1")){
			anim.SetTrigger("Attack1");
		}
		if(Input.GetKeyDown("2")){
			anim.SetTrigger("Attack2");
		}
		if(Input.GetKeyDown("3")){
			anim.SetTrigger("Attack3");
		}
		if(Input.GetKeyDown("4")){
			anim.SetTrigger("Kick1");
		}
		if(Input.GetKeyDown("5")){
			anim.SetTrigger("Kick2");
		}

		//begin Grappling code
		if(Input.GetKey("6")){
			anim.SetTrigger("Grapple1");
			if(distance <= d){grapple=true;}
		}

		if(Input.GetKey("7")){
			anim.SetTrigger("Grapple2");
			if(distance <= d){grapple=true;}

		}
		if(Input.GetKey("8")){
			anim.SetTrigger("Grapple3");
			if(distance <= d){grapple=true;}

		}
		if(Input.GetKeyUp("6")){grapple=false;}
		if(Input.GetKeyUp("7")){grapple=false;}
		if(Input.GetKeyUp("8")){grapple=false;}


		if(Input.GetKeyDown("p")){
			anim.SetTrigger("Punch1");
		}

		//Grapple specific grab animation
		if(Input.GetKey("g")){
			anim.SetBool("Grab",true);
		}
		if(Input.GetKeyUp("g")){
			anim.SetBool("Grab",false);
			grapple = false;
		}
		if(anim.GetBool("Grab") && distance <= d){
			grapple = true;
		}
	
	}


}
