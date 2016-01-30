using UnityEngine;
using System.Collections;

public class Ritual : MonoBehaviour {

	public int[] code;
	public int[] objetosRitual = {50,50,50,50};
	private int i,j;
	// Use this for initialization
	void Start () {
		code = new int[4];
		code[0] = Random.Range(0, 4);
		Debug.Log(code[0]);
		for (i = 1; i < 4; i++) {
			code[i] = Random.Range(0, 4);
			for (j = i-1; j >= 0; j--) {
				if (code[i] == code[j] ) {
					code[i] = Random.Range(0, 4);
					j = i;
				}
			}
			Debug.Log(code[i]);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)){
			print("space key was pressed");
			Debug.Log(objetosRitual[0]);
		}
	}
}
