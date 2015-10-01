using UnityEngine;
using System.Collections;

public class ELvidas : MonoBehaviour
{


    /*
     * intento de jaime por hacer fungir el end less mode
     * manejo de las vidas
     * lso game objects y el fin del jeugo
     * 
     * */

    public GameObject v1;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject v5;
    private GameObject[] bulbul = new GameObject[5];
    public static int cont;
    private int actuales;
    public CreaCreaEndless CCEL;
    public Mover muevemela;


    // Use this for initialization
    void Start()
    {
        cont = actuales = 4;
        bulbul[0] = v1;
        bulbul[1] = v2;
        bulbul[2] = v3;
        bulbul[3] = v4;
        bulbul[4] = v5;
        //		print (bulbul[3]);
    }

    // Update is called once per frame
    void Update()
    {


        /*
         * cuando se baje el cont en la cubeta 
         * o se aumente
         * revisar cont y segun si incremento o disminuyo 
         * cambiar el renderer de las vidas
         * */

        //		print ("A: " + actuales);
        //		print ("C: " + cont);


        if ((difer(actuales, cont)) == 0)
        {

            bulbul[actuales--].SetActive(false);

        }
        else if ((difer(actuales, cont)) == 1)
        {
            bulbul[++actuales].SetActive(true);

        }

        if (actuales < 0)
        {
            CCEL.enabled = false;
            muevemela.enabled = false;
            Fernanda._ferMuere = true;
            StartCoroutine(MyLoadLevel(1.0f));
        }
        //print (actuales);
    }
    IEnumerator MyLoadLevel(float delay)
    {
        addHS(puntos_endless.leScore, PlayerPrefs.GetInt("nivFEL"));
        yield return new WaitForSeconds(delay);
        Application.LoadLevel("scene select");
    }

    int difer(int c1, int c2)
    {

        if ((c1 - c2) < 0)
        {
            return 1;
            // si es un decremento en las vidas regresa un true "1"
        }
        else if ((c1 - c2) > 0)
        {
            return 0;
            //si es un aumento a las vidas regresa un false "0"
        }
        else
        {
            return 9;
            // a la chingada si no es incremento o decremento
        }

    }


    void addHS(int x, int niv)
    {
        switch (niv)
        {
            case 1:
                if (PlayerPrefs.GetInt("HSELeasy") < puntos_endless.leScore)
                {
                    PlayerPrefs.SetInt("HSELeasy", x);
                }
                break;

            case 2:
                if (PlayerPrefs.GetInt("HSELmed") < puntos_endless.leScore)
                {
                    PlayerPrefs.SetInt("HSELmed", x);
                }
                break;

            case 3:
                if (PlayerPrefs.GetInt("HSELhard") < puntos_endless.leScore)
                {
                    PlayerPrefs.SetInt("HSELhard", x);
                }
                break;

            default: break;

        }
    }


}
