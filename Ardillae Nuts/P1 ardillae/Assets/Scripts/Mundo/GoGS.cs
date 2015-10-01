using UnityEngine;
using System.Collections;

/*
 * este script es el que te lleva del menu a la pantalla 
 * de seleccion de jeugo
 * */

public class GoGS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Application.LoadLevel ("gameSelect");
	}
}
