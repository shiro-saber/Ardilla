using UnityEngine;
using System.Collections;

/*
 * script que controla el cronometro en cuenta regresiva
 * termian el jeugo cuando el tiempo se "acaba"
 * */


public class Timer : MonoBehaviour
{
    public static float timer;
    public static float timereamela;
    bool kuz;
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
        kuz = false; //para cambiar los textos
        timer = 30f;//tiempo inicial
        timereamela = 10f; //tiempo para coger lluvia dorada
        Puntos._elMensaje = "Nueces: "; //inicializa el mensaje del gui text de puntos
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!kuz)
        {
            timer -= Time.deltaTime;
            this.GetComponent<GUIText>().text = "Time: " + Mathf.Abs((int)timer);//muestra el tiempo
        }
        else
        {
            timereamela -= Time.deltaTime;
            this.GetComponent<GUIText>().text = "Time: " + Mathf.Abs((int)timereamela);//muestra el tiempo
        }

        if (timer < 10)
            this.GetComponent<GUIText>().color = Color.red;//color rojo para avisar que se acaba el tiempo
  
        if (timer < 0)
        {
            cc.enabled = false;
            if (Puntos.leScore > (PlayerPrefs.GetInt("minNuez") - 1))
            {
                kuz = true;
                pts.color = Color.yellow;// al terminar el tiempo    
                Puntos._elMensaje = "LO LOGRASTE: ";
            }
            else
            {
                pts.color = Color.red;
                Puntos._elMensaje = "NO LO LOGRASTE: ";
                StartCoroutine(MyLoadLevel(1.0f));
            }
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
        Application.LoadLevel("lvl select");
    }
}
