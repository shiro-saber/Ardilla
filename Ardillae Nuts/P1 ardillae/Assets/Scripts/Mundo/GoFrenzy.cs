using UnityEngine;
using System.Collections;


/*
 * este script te lleva al scene select del frenzy mode
 * 
 * */

public class GoFrenzy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
	{
		Application.LoadLevel("frenzySelect");
	}
}
