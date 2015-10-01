using UnityEngine;
using System.Collections;

public class CreaCreaEndless : MonoBehaviour
{

    // Use this for initialization
    /*Este script va a crear los objetos de este tipo de juego*/
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
    private int randomizamela = 0;
    public GameObject vida;
    GameObject life;
    //private int lambda = Cubeta_Endless.regresameVidas();
    void Start()
    {
        frames = 0;
        randomizamela = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        randomizamela = Random.Range(0, 1500);
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

        /*if (/*frames % 100 == 0/* Random.Range (0,100)==1randomizamela == 650)
        {
            porDos = (GameObject)Instantiate(mAmarilla, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //kuz.transform.position = new Vector3 (-3.627431f,9.17924f, 0.0f);
            porDos.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            porDos.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
            porDos.SetActive(true);
            porDos.renderer.enabled = true;
            porDos.rigidbody2D.isKinematic = false;
            //con estas linea creamos una token en una posicion aleatoria (en x) en el nivel
        }*/
        if (/*frames % 100 == 0*//*Random.Range (0,100)==2*/ randomizamela == 650)
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
        if (randomizamela == 990)
        {
            life = (GameObject)Instantiate(vida, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            life.transform.position = new Vector3(Random.Range(-10f, 15f), 9.17924f, 0.0f);
            life.transform.localScale = new Vector3(2.75222f, 2.75222f, 2.75222f);
            life.SetActive(true);
            life.GetComponent<Renderer>().enabled = true;
            life.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
