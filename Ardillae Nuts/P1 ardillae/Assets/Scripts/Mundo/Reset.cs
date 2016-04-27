using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() // esta funcion detecta el click para darle fin a la aplicacion.
    {
       //resetea el progreso del jeugo 
        print("se reseteo");
        PlayerPrefs.SetInt("bool1", 0);
        PlayerPrefs.SetInt("bool2", 0);
        PlayerPrefs.SetInt("bool3", 0);
        PlayerPrefs.SetInt("bool4", 0);
        PlayerPrefs.SetInt("bool5", 0);
        PlayerPrefs.SetInt("bool6", 0);
        PlayerPrefs.SetInt("bool7", 0);
        PlayerPrefs.SetInt("bool8", 0);
        PlayerPrefs.SetInt("bool9", 0);
        PlayerPrefs.SetInt("bool10", 0);
        PlayerPrefs.SetInt("bool11", 0);
        PlayerPrefs.SetInt("bool12", 0);
        PlayerPrefs.SetInt("bool13", 0);
        PlayerPrefs.SetInt("bool14", 0);
        PlayerPrefs.SetInt("bool15", 0);
        PlayerPrefs.SetInt("HSstory", 0);
        PlayerPrefs.SetInt("HSFeasy", 0);
        PlayerPrefs.SetInt("HSFmed", 0);
        PlayerPrefs.SetInt("HSFhard", 0);
        PlayerPrefs.SetInt("HSELeasy", 0);
        PlayerPrefs.SetInt("HSELmed", 0);
        PlayerPrefs.SetInt("HSELhard", 0);
        //booleanos aproximados con integros ya que unity no tiene set/get bool

    }
}
