using UnityEngine;
using System.Collections;

public class vida : MonoBehaviour {


	/*
	 * este script es para lass vidas QUE CAEN
	 * 
	 * */


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (transform.position.y < -4)
        {
            //print ("hola");
            Destroy(this.gameObject);
        }//si el objeto llega al final del escenario (en y) es destruido)
	}
}
