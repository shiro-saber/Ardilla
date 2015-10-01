using UnityEngine;
using System.Collections;

public class Lvl2 : MonoBehaviour
{
    private int niv = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (this.gameObject.name == "niez nivel 2")
        {
            niv = 2;
        }
        else if (this.gameObject.name == "niez nivel 3")
        {
            niv = 3;
        }
        else if (this.gameObject.name == "niez nivel 4")
        {
            niv = 4;
        }
        else if (this.gameObject.name == "niez nivel 5")
        {
            niv = 5;
        }
        else if (this.gameObject.name == "niez nivel 6")
        {
            niv = 6;
        }
        else if (this.gameObject.name == "niez nivel 7")
        {
            niv = 7;
        }
        else if (this.gameObject.name == "niez nivel 8")
        {
            niv = 8;
        }
        else if (this.gameObject.name == "niez nivel 9")
        {
            niv = 9;
        }
        else if (this.gameObject.name == "niez nivel 10")
        {
            niv = 10;
        }
        else if (this.gameObject.name == "niez nivel 11")
        {
            niv = 11;
        }
        else if (this.gameObject.name == "niez nivel 12")
        {
            niv = 12;
        }
        else if (this.gameObject.name == "niez nivel 13")
        {
            niv = 13;
        }
        else if (this.gameObject.name == "niez nivel 14")
        {
            niv = 14;
        }
        else if (this.gameObject.name == "niez nivel 15")
        {
            niv = 15;
        }
        else if (this.gameObject.name == "niez nivel 16")
        {
            niv = 16;
        }






        //print(niv);
        switch (niv)
        {
            case 2:
                //print ("debria ir a lvl 1");
                PlayerPrefs.SetInt("nivel", 2);
                PlayerPrefs.SetInt("minNuez", 25);
                Application.LoadLevel("summer"); //al hacer el click carga el nuevo nivel
                break;
            case 3:
                print ("debria ir a lvl 3");
                PlayerPrefs.SetInt("nivel", 3);
                PlayerPrefs.SetInt("minNuez", 30);
                Application.LoadLevel("summer"); //al hacer el click carga el nuevo nivel
                break;

            case 4:
                print ("debria ir a lvl 4");
                PlayerPrefs.SetInt("nivel", 4);
                PlayerPrefs.SetInt("minNuez", 35);
                Application.LoadLevel("summer"); //al hacer el click carga el nuevo nivel
                break;

            case 5:
                print("debria ir a lvl 5");
                PlayerPrefs.SetInt("nivel", 5);
                PlayerPrefs.SetInt("minNuez", 40);
                Application.LoadLevel("summer"); //al hacer el click carga el nuevo nivel
                break;

            case 6:
                print("debria ir a lvl 6");
                PlayerPrefs.SetInt("nivel", 6);
                PlayerPrefs.SetInt("minNuez", 25);
                Application.LoadLevel("autumn"); //al hacer el click carga el nuevo nivel
                break;

            case 7:
                print("debria ir a lvl 7");
                PlayerPrefs.SetInt("nivel", 7);
                PlayerPrefs.SetInt("minNuez", 30);
                Application.LoadLevel("autumn"); //al hacer el click carga el nuevo nivel
                break;

            case 8:
                print("debria ir a lvl 8");
                PlayerPrefs.SetInt("nivel", 8);
                PlayerPrefs.SetInt("minNuez", 35);
                Application.LoadLevel("autumn"); //al hacer el click carga el nuevo nivel
                break;

            case 9:
                print("debria ir a lvl 9");
                PlayerPrefs.SetInt("nivel", 9);
                PlayerPrefs.SetInt("minNuez", 40);
                Application.LoadLevel("autumn"); //al hacer el click carga el nuevo nivel
                break;

            case 10:
                print("debria ir a lvl 10");
                PlayerPrefs.SetInt("nivel", 10);
                PlayerPrefs.SetInt("minNuez", 45);
                Application.LoadLevel("autumn"); //al hacer el click carga el nuevo nivel
                break;

            case 11:
                print("debria ir a lvl 11");
                PlayerPrefs.SetInt("nivel", 11);
                PlayerPrefs.SetInt("minNuez", 30);
                Application.LoadLevel("winter"); //al hacer el click carga el nuevo nivel
                break;

            case 12:
                print("debria ir a lvl 12");
                PlayerPrefs.SetInt("nivel", 12);
                PlayerPrefs.SetInt("minNuez", 35);
                Application.LoadLevel("winter"); //al hacer el click carga el nuevo nivel
                break;

            case 13:
                print("debria ir a lvl 13");
                PlayerPrefs.SetInt("nivel", 13);
                PlayerPrefs.SetInt("minNuez", 40);
                Application.LoadLevel("winter"); //al hacer el click carga el nuevo nivel
                break;

            case 14:
                print("debria ir a lvl 14");
                PlayerPrefs.SetInt("nivel", 14);
                PlayerPrefs.SetInt("minNuez", 45);
                Application.LoadLevel("winter"); //al hacer el click carga el nuevo nivel
                break;

            case 15:
                print("debria ir a lvl 15");
                PlayerPrefs.SetInt("nivel", 15);
                PlayerPrefs.SetInt("minNuez", 50);
                Application.LoadLevel("winter"); //al hacer el click carga el nuevo nivel
                break;

            case 16:
                print("debria ir a lvl 16");
                PlayerPrefs.SetInt("nivel", 16);
                PlayerPrefs.SetInt("minNuez", 60);
                Application.LoadLevel("winter"); //al hacer el click carga el nuevo nivel
                break;
        }
       

    }
}
