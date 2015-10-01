using UnityEngine;
using System.Collections;

/*
 * script que controla el cronometro en cuenta regresiva
 * termian el jeugo cuando el tiempo se "acaba"
 * */


public class Timer : MonoBehaviour
{
    public static float timer;
    public Creacrea cc;
    public GUIText pts;
	public CreaDoradas cd;
    public GameObject personaj;
    //GameObject[] lluviaDorada;
    private bool norepetir=true;

    // Use this for initialization
    void Start()
    {
        norepetir = true;
        timer = 30f;//tiempo inicial
        Puntos._elMensaje = "Nueces: "; //inicializa el mensaje del gui text de puntos
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        this.GetComponent<GUIText>().text = "Time: " + Mathf.Abs((int)timer);//muestra el tiempo
        if (timer < 10)
        {
            this.GetComponent<GUIText>().color = Color.red;//color rojo para avisar que se acaba el tiempo
        }
        if (timer < 0)
        {
            cc.enabled = false;
            if (Puntos.leScore > (PlayerPrefs.GetInt("minNuez") - 1))
            {
                
                Puntos._elMensaje = "LO LOGRASTE: ";
                //lluviaDorada = GameObject.FindGameObjectsWithTag("golden");
                //if (lluviaDorada.Length == 0)
                //{
                //    Application.LoadLevel("lvl select");//termina el nivel y regresa el menu principal
                //}
            }
            else
            {
                Puntos._elMensaje = "NO LO LOGRASTE: ";
                StartCoroutine(MyLoadLevel(1.0f));
            }
            pts.color = Color.yellow;// al terminar el tiempo 

        }

		if (Puntos.leScore > (PlayerPrefs.GetInt("minNuez")-1) && timer<  0) {
			//print ("deveria lanzar neuzes de oro");
			cd.enabled=true;
            if(norepetir)
            {
                personaj.GetComponent<AudioSource>().Play();
                norepetir = false;
            }
        }//si el usuario junto el minimo de neuces requeridas  activa el script de creacion de nueces doradas
    }

    IEnumerator MyLoadLevel(float delay)
    {
        yield return new WaitForSeconds(delay);
        Application.LoadLevel("scene select");
    }
}
