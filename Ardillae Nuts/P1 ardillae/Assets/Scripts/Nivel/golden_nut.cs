using UnityEngine;
using System.Collections;

public class golden_nut : MonoBehaviour {

	public CreaDoradas cd;

	// Use this for initialization
	void Start () {
		cd.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -4)
		{
			//print ("hola");
			Destroy(this.gameObject);
		}//si el objeto llega al final del escenario (en y) es destruido)
	}
}
