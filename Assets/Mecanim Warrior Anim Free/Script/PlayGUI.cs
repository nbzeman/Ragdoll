using UnityEngine;
using System.Collections;

public class PlayGUI : MonoBehaviour {
	public Transform[] transforms;
	
	public GUIContent[] GUIContents;

	private Animator[] animator;
	
	private string currentState = "";

	// Use this for initialization
	void Start () {
    animator = new Animator[transforms.Length];
		for (int i = 0; i < transforms.Length; i++) {
			animator[i] = transforms[i].GetComponent<Animator>();
		}
	}

	void OnGUI() {
		GUILayout.BeginVertical("box");
		for (int i = 0; i < GUIContents.Length; i++) {
			
			if (GUILayout.Button(GUIContents[i])) {
				currentState = GUIContents[i].text;
			}
			
			AnimatorStateInfo stateInfo = animator[0].GetCurrentAnimatorStateInfo(0);
			
			if (!stateInfo.IsName("Base Layer.idle2")) {
		        for (int j = 0; j < animator.Length; j++) {
		          animator[j].SetBool("idle2ToIdle0", false);
		          animator[j].SetBool("idle2ToIdle1", false);
		          animator[j].SetBool("idle2ToWalk", false);
		          animator[j].SetBool("idle2ToRun", false);
		          animator[j].SetBool("idle2ToWound", false);
		          animator[j].SetBool("idle2ToSkill1", false);
		          animator[j].SetBool("idle2ToSkill0", false);
		          animator[j].SetBool("idle2ToAttack1", false);
		          animator[j].SetBool("idle2ToAttack0", false);
		          animator[j].SetBool("idle2ToDeath", false);
		        }
			} else {
				for (int j = 0; j < animator.Length; j++) {
		          animator[j].SetBool("walkToIdle2", false);
		          animator[j].SetBool("runToIdle2", false);
		          animator[j].SetBool("deathToIdle2", false);
				}
			}
			
			if (currentState != "") {
				if (stateInfo.IsName("Base Layer.walk") && currentState != "walk") {
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("walkToIdle2", true);
					}
				}
				
				if (stateInfo.IsName("Base Layer.run") && currentState != "run") {
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("runToIdle2", true);
					}
				}
				
				if (stateInfo.IsName("Base Layer.death") && currentState != "death") {
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("deathToIdle2", true);
					}
				}
				
				switch (currentState) {
		        case "idle0":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToIdle0", true);
					}				
					break;
		        case "idle1":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToIdle1", true);
					}
					break;
		        case "idle2":
					
					break;
				case "walk":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToWalk", true);
					}
					break;
				case "run":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToRun", true);
					}
					break;
				case "attack0":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToAttack0", true);
					}
					break;
				case "attack1":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToAttack1", true);
					}
					break;
				case "skill0":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToSkill0", true);
					}
					break;
				case "skill1":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToSkill1", true);
					}
					break;
				case "wound":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToWound", true);
					}
					break;
				case "death":
					for (int j = 0; j < animator.Length; j++) {
						animator[j].SetBool("idle2ToDeath", true);
					}
					break;					
					
				default:
				break;
				}
				currentState = "";
			}
		}
		GUILayout.EndVertical();
	}
	
	

}
