using UnityEngine;
using System.Collections;

public class Cubeta_Endless : MonoBehaviour
{
    // Use this for initialization
    /*En este script se detectara la caida de las nueces dentro de la cubeta, asi como la desaparicion de vidas cuando se atrapa una bomba*/
    GameObject[] tutzke;
    private int modishne = 0;
    //private int frames = 0;
    //private bool gChanged = false;
    public Health health;
    public GameObject BombAnim;
    public GameObject kuz;
    public GameObject zain;
    public GameObject sharmuta;
    //public static int vaginas = 5; //las vidas
    //public static int i = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (vaginas == 0)
        //{
            //StartCoroutine(LoadLevel("scene select", 6.5f));
            //vaginas = 5;
        //}
    }

    //IEnumerator LoadLevel(string level, float TimetoWait)
    //{
    //    yield return new WaitForSeconds(TimetoWait);
    //    Application.LoadLevel(level);
    //}
    void OnCollisionEnter2D(Collision2D col)
    {
        //funcion para detectar que esta entrando ala cubeta de fernanda
        //print ("colisiono");
        if (col.gameObject.tag == "nut")
        {
            sharmuta.gameObject.GetComponent<AudioSource>().Play();
            puntos_endless._puntos = (1 * puntos_endless._pwrpuntos);//aumentamos el contador de neuces
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "bomb2")
        {
            kuz.gameObject.GetComponent<AudioSource>().Play();
            //if (puntos_endless.leScore > 4)//evitamos score negativo
            //{
            //    puntos_endless._puntos = -5;//restamos del contador de neuces
            //}
            //else
            //{
            //    puntos_endless.leScore = 0;
            //}
            BombAnim.transform.position = col.transform.position;
			ELvidas.cont--;
            Destroy(col.gameObject);
//            health.ModifyHealth(-10);
        }
        else if (col.gameObject.tag == "multi")
        {
            zain.gameObject.GetComponent<AudioSource>().Play();
            puntos_endless._pwrpuntos = 2;//aumenta el multiplicadore de puntos
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
        else if (col.gameObject.tag == "coge")
        {

			if(ELvidas.cont<4)
			{

				//si el jugador tiene menos vidas de 5, aumentar
				ELvidas.cont++;
			}

            Destroy(col.gameObject);
//            health.AddHearts(1);

           // vaginas++; //si atrapas dibujito de ardilla sumas una vida
           // i--;
        }//se aumentan el contador de vidas si cachas un 1-up
    }
    //public static int regresameVidas()
    //{
      //  return vaginas;
    //}
}