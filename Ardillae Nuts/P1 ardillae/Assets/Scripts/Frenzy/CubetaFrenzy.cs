using UnityEngine;
using System.Collections;


/*
 * este script esta en al cubeta que hace
 * el cambio de la variable para sumar puntos
 * el cambio de la varaible para restar puntos
 * el cambio de la variable que multiplica puntos
 * el cambio de la variable que acelera a fernanda
 * el cambio de la gravedad
 * la destruccion de las bombas 
 * */


public class CubetaFrenzy : MonoBehaviour
{
	GameObject[] tutzke;
	private int modishne = 0;
	private int frames = 0;
	private bool gChanged = false;
	public GameObject BombAnim;
	public GameObject kuz;
	public GameObject zain;
	public GameObject sharmuta;
	public GameObject tajat;
	
	// Use this for initialization
	void Start()
	{
		Physics2D.gravity = new Vector3(0f, -7f, 0f);
	}
	
	// Update is called once per frame
	void Update()
	{
		
		if (gChanged)
		{
			frames++;
			if (frames >= 500)
			{
				Physics2D.gravity = new Vector3(0f, -7f, 0f);
				frames = 0;
				gChanged = false;
			}
		}// regresa la gravedad a la normalidadt
		//print (Physics.gravity.ToString);
		//print (frames);
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		//funcion para detectar que esta entrando ala cubeta de fernanda
		//print ("colisiono");
		if (col.gameObject.tag == "nut")
		{
			sharmuta.gameObject.GetComponent<AudioSource>().Play();
			PuntosFrenzy._puntos = (1 * PuntosFrenzy._pwrpuntos);//aumentamos el contador de neuces
			Destroy(col.gameObject);
		}
		else if (col.gameObject.tag == "bomb2")
		{
			//col.gameObject.audio.Play();
			kuz.gameObject.GetComponent<AudioSource>().Play();
			if (PuntosFrenzy.leScore > 4)//evitamos score negativo
			{
				PuntosFrenzy._puntos = -5;//restamos del contador de neuces
			}
			else
			{
				PuntosFrenzy.leScore = 0;
			}
			BombAnim.transform.position = col.transform.position;
			Destroy(col.gameObject);
		}
		else if (col.gameObject.tag == "multi")
		{
			zain.gameObject.GetComponent<AudioSource>().Play();
			PuntosFrenzy._pwrpuntos = 2;//aumenta el multiplicadore de puntos
			Destroy(col.gameObject);
		}
		else if (col.gameObject.tag == "dest")
		{
			//Destroy(GameObject.Find("temp bomb(Clone)"));
			zain.gameObject.GetComponent<AudioSource>().Play();
			tutzke = GameObject.FindGameObjectsWithTag("bomb2");
			modishne = tutzke.Length;
			for (int i = 0; i < modishne; i++)
			{
				Destroy(tutzke[i]);
			}
			Destroy(col.gameObject);//dsetruye el token 
			//destruye las bombas en la pantalla
		}
		else if (col.gameObject.tag == "rabit")
		{
			zain.gameObject.GetComponent<AudioSource>().Play();
			Mover._spdMult = 1.2f;
			Destroy(col.gameObject);
			//acelera fernanda
		}
		else if (col.gameObject.tag == "snail")
		{
			zain.gameObject.GetComponent<AudioSource>().Play();
			Physics2D.gravity = new Vector3(0.0f, -3f, 0f);
			Destroy(col.gameObject);
			gChanged = true;
			//alentiza nueces y/o bombas 
		}
		//		else if (col.gameObject.tag == "golden")
		//		{
		//			
		//			//PlayerPrefs.SetInt("bool1", 1);
		//			
		//			//switch para desbloqueo de niveles
		//			tajat.gameObject.audio.Play();
		//			switch (PlayerPrefs.GetInt("nivel"))
		//			{
		//			case 1:
		//				PlayerPrefs.SetInt("bool1", 1);
		//				break;
		//				
		//			case 2:
		//				PlayerPrefs.SetInt("bool2", 1);
		//				break;
		//				
		//			case 3:
		//				PlayerPrefs.SetInt("bool3", 1);
		//				break;
		//				
		//			case 4:
		//				PlayerPrefs.SetInt("bool4", 1);
		//				break;
		//				
		//			case 5:
		//				PlayerPrefs.SetInt("bool5", 1);
		//				break;
		//				
		//			case 6:
		//				PlayerPrefs.SetInt("bool6", 1);
		//				break;
		//				
		//			case 7:
		//				PlayerPrefs.SetInt("bool7", 1);
		//				break;
		//				
		//			case 8:
		//				PlayerPrefs.SetInt("bool8", 1);
		//				break;
		//				
		//			case 9:
		//				PlayerPrefs.SetInt("bool9", 1);
		//				break;
		//				
		//			case 10:
		//				PlayerPrefs.SetInt("bool10", 1);
		//				break;
		//				
		//			case 11:
		//				PlayerPrefs.SetInt("bool11", 1);
		//				break;
		//				
		//				
		//			case 12:
		//				PlayerPrefs.SetInt("bool12", 1);
		//				break;
		//				
		//			case 13:
		//				PlayerPrefs.SetInt("bool13", 1);
		//				break;
		//				
		//			case 14:
		//				PlayerPrefs.SetInt("bool14", 1);
		//				break;
		//				
		//			case 15:
		//				PlayerPrefs.SetInt("bool15", 1);
		//				break;
		//				
		//			case 16:
		//				PlayerPrefs.SetInt("bool16", 1);
		//				break;
		//				
		//			}
		//			
		//			
		//			Puntos._puntos = (10 * Puntos._pwrpuntos);
		//			Destroy(col.gameObject);
		//			
		//		}
		/*
        revisamos que objeto choco con el collider de la cubeta
        dependiendo el objeto es el metodo que se manda llamar
        y es destruido 

          */
		
		
	}
}
