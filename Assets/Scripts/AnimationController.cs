using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float ranim = Input.GetAxis ("Horizontal");
		if (Input.GetAxis ("Vertical") > 0 || (Input.GetAxis ("Vertical") < 0) || ranim < 0 || ranim > 0) {
			anim.SetBool ("Move", true);
		} else {
			anim.SetBool ("Move", false);
		}

		anim.SetFloat ("Rotate", Input.GetAxis("Horizontal"));

		if (Input.GetKeyDown (KeyCode.JoystickButton0)) {
			StartCoroutine (TakeTime());
		}




	}
	IEnumerator TakeTime(){
		anim.SetBool ("Take", true);
		yield return new WaitForSeconds(2);
		anim.SetBool ("Take", false);
	}
}
