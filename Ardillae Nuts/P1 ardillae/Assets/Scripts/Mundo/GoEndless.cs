using UnityEngine;
using System.Collections;


/*
 * este script es para ir del tipo de jeugo al endless select 
 * */

public class GoEndless : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Application.LoadLevel(6);
	}

}
