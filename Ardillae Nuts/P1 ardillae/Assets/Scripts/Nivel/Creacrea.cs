using UnityEngine;
using System.Collections;

public class Creacrea : MonoBehaviour
{
    public GameObject nuez;
    private int frames;
    GameObject kuz;//para instancair nueces
    public GameObject kaBOOOM;
    GameObject ahiValaBaala;//para las bombas
    //power ups
    public GameObject mAmarilla;
    GameObject porDos;//power up de multiplicarciont ermporal de score
    // Use this for initialization
    public GameObject mRoja;
    GameObject destru;
    public GameObject mAzul;
    GameObject conejo;
    public GameObject mVerde;
    GameObject caracol;

    private int randomizamela = 0;

    //-----------------------------------------------------------------------
    void Start()
    {
        frames = 0;
        randomizamela = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        randomizamela = Random.Range(0, 200);
        /*
         * x izquierda ~ -15.91475 
         * x derecha ~ 20.90424
         *
         * 	y = 4.585123
         * 	
         * valores de longitud y altura del esenario
         */
        if (frames % 10 == 0)
        {
            kuz = (GameObject)Instantiate(nuez, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            kuz.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            kuz.transform.localScale = new Vector3(0.1252655f, 0.1252655f, 1f);
            kuz.SetActive(true);
            kuz.GetComponent<Renderer>().enabled = true;
            kuz.GetComponent<Rigidbody2D>().isKinematic = false;
            //con estas linea creamos una nez en una posicion aleatoria (en x) en el nivel
        }

        if (frames % 50 == 0)
        {
            ahiValaBaala = (GameObject)Instantiate(kaBOOOM, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            ahiValaBaala.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            ahiValaBaala.transform.localScale = new Vector3(0.5687609f, 0.5687609f, 1f);
            ahiValaBaala.SetActive(true);
            ahiValaBaala.GetComponent<Renderer>().enabled = true;
            ahiValaBaala.GetComponent<Rigidbody2D>().isKinematic = false;
            ahiValaBaala.tag = "bomb2";
            //con estas linea creamos una bomba en una posicion aleatoria (en x) en el nivel
        }

        if (/*frames % 100 == 0*//* Random.Range (0,100)==1*/randomizamela == 1)
        {
            porDos = (GameObject)Instantiate(mAmarilla, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            porDos.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            porDos.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
            porDos.SetActive(true);
            porDos.GetComponent<Renderer>().enabled = true;
            porDos.GetComponent<Rigidbody2D>().isKinematic = false;
            //con estas linea creamos una token en una posicion aleatoria (en x) en el nivel
        }
        if (/*frames % 100 == 0*//*Random.Range (0,100)==2*/ randomizamela == 2)
        {
            destru = (GameObject)Instantiate(mRoja, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            destru.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            destru.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
            destru.SetActive(true);
            destru.GetComponent<Renderer>().enabled = true;
            destru.GetComponent<Rigidbody2D>().isKinematic = false;
            //con estas linea creamos una token en una posicion aleatoria (en x) en el nivel
        }

        if (/*frames % 100 == 0*//*Random.Range (0,100)==3*/randomizamela == 3)
        {
            conejo = (GameObject)Instantiate(mAzul, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            conejo.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            conejo.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
            conejo.SetActive(true);
            conejo.GetComponent<Renderer>().enabled = true;
            conejo.GetComponent<Rigidbody2D>().isKinematic = false;
            //con estas linea creamos una token en una posicion aleatoria (en x) en el nivel
        }

        if (/*frames % 100 == 0*//*Random.Range (0,100)==4*/randomizamela == 4)
        {
            caracol = (GameObject)Instantiate(mVerde, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            caracol.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            caracol.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
            caracol.SetActive(true);
            caracol.GetComponent<Renderer>().enabled = true;
            caracol.GetComponent<Rigidbody2D>().isKinematic = false;
            //con estas linea creamos una token en una posicion aleatoria (en x) en el nivel
        }

    }
}









