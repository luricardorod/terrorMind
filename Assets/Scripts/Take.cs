using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Take : MonoBehaviour {

	// Use this for initialization
	public Transform spawner;
	private GameObject objMano;
	public int x,y,z;
	private bool flag = false;
	void Start () {
		//AudioSource audi = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray rayo = Camera.main.ScreenPointToRay (new Vector3(x,y,z));
		Debug.DrawRay(rayo.origin, rayo.direction * 2, Color.yellow);
		if(Input.GetKeyDown(KeyCode.X) || Input.GetKeyUp(KeyCode.JoystickButton0)){
			Debug.Log("hoiol");
			if (Physics.Raycast (rayo, out hit, 2)) {
				if (hit.collider.tag == "Object") {
					objMano = hit.collider.gameObject;
					objMano.gameObject.SetActive(false);
					Debug.Log ("Object encontrado");
					flag = true;
				}
			}
		}

		if (flag) {
			if(Input.GetKeyUp(KeyCode.X) || Input.GetKeyUp(KeyCode.JoystickButton0)){
				objMano.gameObject.transform.position = spawner.gameObject.transform.position;
				objMano.gameObject.SetActive(true);

				Debug.Log("hoiol");
				flag = false;
			}
		}


	}


}
