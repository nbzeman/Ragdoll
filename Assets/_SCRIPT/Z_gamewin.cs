using UnityEngine;
using System.Collections;

public class Z_gamewin : MonoBehaviour {

	public int test;
	public static bool win;
	public Transform genericJoe;

	void Update(){

		print (test);
	}

	IEnumerator OnTriggerEnter(Collider col){
		
		if(col.gameObject.tag == "ground"){
			GameObject ind = GameObject.Find("WinText");
			ind.guiText.text="You Win!";
			win = true;
			genericJoe.transform.position = new Vector3(-7.0f,3.662901f,-2.3f);
			print ("generic joe");
			yield return new WaitForSeconds(.5f);
			ind.guiText.text="";
			win = false;

		}
	}
}
