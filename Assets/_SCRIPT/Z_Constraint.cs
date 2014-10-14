using UnityEngine;
using System.Collections;

public class Z_Constraint : MonoBehaviour {


	public bool t_constraintOn = false;
	public bool r_constraintOn = false;
	public bool p_constraintOn = false;
	public Transform t_target;
	public Transform t_target_offset;
	public Transform r_target;
	public Vector3 offset = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
	
		if(!t_target_offset){
			offset = new Vector3(0,0,0);
		}
	}
	
	// Update is called once per frame
	void Update () {



		if (Z_Attacks.grapple) {

			transform.position = t_target.position - offset;
			 
		}
		if (r_constraintOn) {

			transform.rotation = r_target.rotation;
		}
	}
}
