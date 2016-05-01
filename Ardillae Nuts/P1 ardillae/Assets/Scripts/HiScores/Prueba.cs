using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Prueba : MonoBehaviour
{
    Text []tujefe;

    /*
     * este script sirve para la pantalla de high scores 
     * pone el mas alto ene pantalla
     * 
     * el arreglo en la pos 1 =  story
     * pos 2-4 = frenzy
     * 
     * pos 5-7 = endless
     * */

	// Use this for initialization
	void Start ()
    {
        /* Cambio a uso de canvas para Unity 5 */
        tujefe = GetComponentsInChildren<Text>();
        
        tujefe[1].text += PlayerPrefs.GetInt("HSstory");
        tujefe[2].text += PlayerPrefs.GetInt("HSFeasy");
        tujefe[3].text += PlayerPrefs.GetInt("HSFmed");
        tujefe[4].text += PlayerPrefs.GetInt("HSFhard");
        tujefe[5].text += PlayerPrefs.GetInt("HSELeasy");
        tujefe[6].text += PlayerPrefs.GetInt("HSELmed");
        tujefe[7].text += PlayerPrefs.GetInt("HSELhard");

        /*int uno, dos, tres, cuatro, cinco, seis, tuputamadre;

        uno = PlayerPrefs.GetInt("HSstory");
        dos = PlayerPrefs.GetInt("HSFeasy");
        tres = PlayerPrefs.GetInt("HSFmed");
        cuatro = PlayerPrefs.GetInt("HSFhard");
        cinco = PlayerPrefs.GetInt("HSELeasy");
        seis = PlayerPrefs.GetInt("HSELmed");
        tuputamadre = PlayerPrefs.GetInt("HSELhard");

        print("Este es uno "+uno+"\nEste es dos "+dos+"\nEste es tres "+tres+"\nEste es cuatro "+cuatro+"\nEste es cinco "+cinco+"\nEste es seis "+seis+"\nEsta es tuputamadre "+tuputamadre+"\n");*/
        //agregar al text el scrore guardado en lso player prefs
	}
	
	// Update is called once per frame
	void Update (){}
}
