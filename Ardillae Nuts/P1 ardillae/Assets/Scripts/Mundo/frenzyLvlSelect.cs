using UnityEngine;
using System.Collections;


/*
 * este script es apra elegir el nivel de frenzy que se juagra
 * */

public class frenzyLvlSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{
		print ("click");
		if(this.gameObject.name == "ELeasy")
		{
            PlayerPrefs.SetInt("nivFEL", 1);
			Application.LoadLevel("summer_frenzy");
		}
		else if(this.gameObject.name == "ELmed")
		{
            PlayerPrefs.SetInt("nivFEL", 2);
			Application.LoadLevel("autum_frenzy");
		}
		else if(this.gameObject.name == "ELhard")
		{
            PlayerPrefs.SetInt("nivFEL", 3);
			Application.LoadLevel("winter_frenzy");
		}
		

	}
}
