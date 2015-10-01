using UnityEngine;
using System.Collections;

public class TimerFrenzy : MonoBehaviour
{
    public static float timer;
    public Creacrea cc;
    public GUIText pts;
    public CreaDoradas cd;
    public GameObject personaj;
    //private bool norepetir = true;

    // Use this for initialization
    void Start()
    {
        //norepetir = true;
        timer = 60f;//tiempo inicial
        Puntos._elMensaje = "Nueces: "; //inicializa el mensaje del gui text de puntos
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        //timer += Time.deltaTime;
        this.GetComponent<GUIText>().text = "Time: " + Mathf.Abs((int)timer);//muestra el tiempo
        if (timer < 0)
        {
            StartCoroutine(MyLoadLevel(1.0f));
        }
    }

    IEnumerator MyLoadLevel(float delay)
    {
        addHS(PuntosFrenzy.leScore, PlayerPrefs.GetInt("nivFEL"));
        yield return new WaitForSeconds(delay);
        Application.LoadLevel("frenzySelect");
    }

    void addHS(int x, int niv)
    {
        switch(niv)
        {
            case 1:
                if (PlayerPrefs.GetInt("HSFeasy") < PuntosFrenzy.leScore)
                {
                    PlayerPrefs.SetInt("HSFeasy", x);
                }
                break;
            
            case 2:
                if (PlayerPrefs.GetInt("HSFmed") < PuntosFrenzy.leScore)
                {
                    PlayerPrefs.SetInt("HSFmed", x);
                }
                break;

            case 3:
                if (PlayerPrefs.GetInt("HSFhard") < PuntosFrenzy.leScore)
                {
                    PlayerPrefs.SetInt("HSFhard", x);
                }
                break;

            default: break;

        }
    }

}
