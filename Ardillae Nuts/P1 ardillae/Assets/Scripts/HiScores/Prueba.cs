using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Prueba : MonoBehaviour {

    //Text tujefa;
    Text []tujefe;


    /*
     * este script sirve para la pantalla de high scores 
     * pone el mas alto ene pantalla
     * 
     * el arreglo en la pos 1 =  story
     * pos 2-4 = frenzy
     * 
     * pos 5-7 = endless
     * 
     * */


	// Use this for initialization
	void Start () {
        //this.guiText.text = "tu mama";
        //tujefa = GetComponent<Text>();
        tujefe = GetComponentsInChildren<Text>();
        //tujefe[2].text += "tu reputa madre";

        tujefe[1].text += PlayerPrefs.GetInt("HSstory");
        tujefe[2].text += PlayerPrefs.GetInt("HSFeasy");
        tujefe[3].text += PlayerPrefs.GetInt("HSFmed");
        tujefe[4].text += PlayerPrefs.GetInt("HSFhard");
        tujefe[5].text += PlayerPrefs.GetInt("HSELeasy");
        tujefe[6].text += PlayerPrefs.GetInt("HSELmed");
        tujefe[7].text += PlayerPrefs.GetInt("HSELhard");
        
        //agregar al text el scrore guardado en lso player prefs
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
