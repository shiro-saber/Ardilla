using UnityEngine;
using System.Collections;

/*
 * este script carga en nivel de endless seleccionado
 * */


public class Endless_scene : MonoBehaviour {
//    private int lvl = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
		print ("click");
        if(this.gameObject.name == "ELeasy")
        {
            PlayerPrefs.SetInt("nivFEL", 1);
			Application.LoadLevel("summer_endless");
        }
        else if(this.gameObject.name == "ELmed")
        {
            PlayerPrefs.SetInt("nivFEL", 2);
			Application.LoadLevel("autum_endless");
        }
        else if(this.gameObject.name == "ELhard")
        {
            PlayerPrefs.SetInt("nivFEL", 3);
			Application.LoadLevel("winter_endless");
        }



    }
}
