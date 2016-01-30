using UnityEngine;
using System.Collections;

public class ObjetoEnCaja : MonoBehaviour {
	public GameObject ritualMaster;
	public int lugarCodigo;
	// Use this for initialization
	void Start () {
		lugarCodigo = gameObject.GetComponent<valorObjeto>().valor;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
    Debug.Log(other.name);
		ritualMaster.gameObject.GetComponent<Ritual>().objetosRitual[lugarCodigo] = other.gameObject.GetComponent<valorObjeto>().valor;
  }
}
