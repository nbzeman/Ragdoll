using UnityEngine;
using System.Collections;

public class Z_Camswitch : MonoBehaviour {

	public Rect HUDRect = new Rect(40,40,40,40);
	public bool shouldercam;
	public GameObject ringCam;
	private Transform ringCamt;
	public GameObject shoulderCam;
	private Transform shoulderCamt;

	public GUISkin myskin;

	// Use this for initialization
	void Start () {

		shoulderCam.gameObject.tag = "secondary camera";
		shoulderCamt = shoulderCam.transform;
		ringCam.gameObject.tag = "MainCamera";
		ringCamt = ringCam.transform;

	
	
	}
	
	// Update is called once per frame
	void Update () {

		if(!shouldercam){

			ringCam.SetActive(true);
			ringCam.gameObject.tag = "MainCamera";
	
			shoulderCam.SetActive (false);
			shoulderCam.gameObject.tag = "secondary camera";

			ThirdPersonUserControl.cam = ringCamt;
		}
		if(shouldercam){

			ringCam.gameObject.tag = "secondary camera";
			ringCam.SetActive(false);

			shoulderCam.gameObject.tag = "MainCamera";
			shoulderCam.SetActive (true);

			ThirdPersonUserControl.cam = shoulderCamt;

		}
	}


	void OnGUI(){

		GUI.skin = myskin;
		GUILayout.BeginArea (HUDRect);
		shouldercam = GUILayout.Toggle (shouldercam, "switch camera");
		GUILayout.EndArea ();
	}
}
