using UnityEngine;
using System.Collections;

public class Lvl1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        //print ("debria ir a lvl 1");
        PlayerPrefs.SetInt("nivel", 1);
        PlayerPrefs.SetInt("minNuez", 20);
        Application.LoadLevel("summer"); //al hacer click carga el primer nivel

    }
}
