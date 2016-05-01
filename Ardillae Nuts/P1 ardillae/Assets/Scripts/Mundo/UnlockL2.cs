using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnlockL2 : MonoBehaviour
{
    /*
     * este script hace el bloqueo y desbloqueo de niveles
     * Este script esta encargado de desaparecer el icono de candado que bloquea el nivel.
     */
    public GameObject nuez1;
    public GameObject nuez2;
    public GameObject nuez3;
    public GameObject nuez4;
    public GameObject nuez5;
    public GameObject nuez6;
    public GameObject nuez7;
    public GameObject nuez8;
    public GameObject nuez9;
    public GameObject nuez10;
    public GameObject nuez11;
    public GameObject nuez12;
    public GameObject nuez13;
    public GameObject nuez14;
    public GameObject nuez15;
    public GameObject nuez16;


    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("nivel", 0);

        nuez2.SetActive(false);
        nuez3.SetActive(false);
        nuez4.SetActive(false);
        nuez5.SetActive(false);
        nuez6.SetActive(false);
        nuez7.SetActive(false);
        nuez8.SetActive(false);
        nuez9.SetActive(false);
        nuez10.SetActive(false);
        nuez11.SetActive(false);
        nuez12.SetActive(false);
        nuez13.SetActive(false);
        nuez14.SetActive(false);
        nuez15.SetActive(false);
        nuez16.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "candado 1")
        {
            if (PlayerPrefs.GetInt("bool1") == 1)
            {
                nuez2.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez2.SetActive(false);
                this.GetComponent<Image>().enabled = true;// si se resetea eñ nvel que regrese todo
            }
        }


        if (this.gameObject.name == "candado 2")
        {
            if (PlayerPrefs.GetInt("bool2") == 1)
            {
                nuez3.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez3.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 3")
        {
            if (PlayerPrefs.GetInt("bool3") == 1)
            {
                nuez4.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez4.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 4")
        {
            if (PlayerPrefs.GetInt("bool4") == 1)
            {
                nuez5.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez5.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 5")
        {
            if (PlayerPrefs.GetInt("bool5") == 1)
            {
                nuez6.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez6.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 6")
        {
            if (PlayerPrefs.GetInt("bool6") == 1)
            {
                nuez7.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez7.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 7")
        {
            if (PlayerPrefs.GetInt("bool7") == 1)
            {
                nuez8.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez8.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 8")
        {
            if (PlayerPrefs.GetInt("bool8") == 1)
            {
                nuez9.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez9.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 9")
        {
            if (PlayerPrefs.GetInt("bool9") == 1)
            {
                nuez10.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez10.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 10")
        {
            if (PlayerPrefs.GetInt("bool10") == 1)
            {
                nuez11.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez11.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 11")
        {
            if (PlayerPrefs.GetInt("bool11") == 1)
            {
                nuez12.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez12.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }
        
        if (this.gameObject.name == "candado 12")
        {
            if (PlayerPrefs.GetInt("bool12") == 1)
            {
                nuez13.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez13.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 13")
        {
            if (PlayerPrefs.GetInt("bool13") == 1)
            {
                nuez14.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez14.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 14")
        {
            if (PlayerPrefs.GetInt("bool14") == 1)
            {
                nuez15.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez15.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }

        if (this.gameObject.name == "candado 15")
        {
            if (PlayerPrefs.GetInt("bool15") == 1)
            {
                nuez16.SetActive(true);//si el nivel fue pasado habilita el siguiente nivel
                this.GetComponent<Image>().enabled = false;
            }
            else
            {
                nuez16.SetActive(false);
                this.GetComponent<Image>().enabled = true;
            }
        }
    }
}
