﻿using UnityEngine;
using System.Collections;

public class CreaDoradas : MonoBehaviour {
	public GameObject laDorada;
	GameObject NuezOro;
	private int cuantasTienes=17;
	private int frames=0;
	private bool creda =false; //para que no se salga antes de crear una nuez
	// Use this for initialization
	void Start () {

        cuantasTienes -= PlayerPrefs.GetInt("nivel");

	}
	
	// Update is called once per frame
	void Update () {
		if(cuantasTienes >=0)
		{
			frames++;
			if(frames%30 ==0){
			NuezOro = (GameObject)Instantiate(laDorada, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
			NuezOro.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
			NuezOro.transform.localScale = new Vector3(0.1252655f, 0.1252655f, 1f);
			NuezOro.SetActive(true);
//				NuezOro.tag = "pene";
			NuezOro.GetComponent<Renderer>().enabled = true;
			NuezOro.GetComponent<Rigidbody2D>().isKinematic = false;
			cuantasTienes--;
				creda =true;
			} //este es el creador en random de las nueces doradas que debera atrapar al final del nivel
		}
//        else
//        {
//            Application.LoadLevel("lvl select");
//        }
//		print (GameObject.FindGameObjectsWithTag("pene").Length);
		if ((GameObject.FindGameObjectsWithTag("golden").Length == 1) && creda) {
            //print("pene");
            StartCoroutine(MyLoadLevel(1.0f));
				}
	}

    IEnumerator MyLoadLevel(float delay)
    {
        addHS(Puntos.leScore);
        yield return new WaitForSeconds(delay);
        Application.LoadLevel("lvl select");
    }
    void addHS(int x)
    {
        PlayerPrefs.SetInt("HSstory", (x + PlayerPrefs.GetInt("HSstory")));
    }

}
