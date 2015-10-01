using UnityEngine;
using System.Collections;

public class puntos_endless : MonoBehaviour
{

    // Use this for initialization
    /*Este script suma los puntos en el endless hasta que las vidas se acaban*/
    public static int _puntos = 0;
    public static int _pwrpuntos;
    public static string _elMensaje;
    private int frames = 0;
    public static int leScore;

    void Start()
    {
        _pwrpuntos = 1;
        _elMensaje = "Nueces";
        leScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        leScore += _puntos;
        _puntos = 0;
        this.GetComponent<GUIText>().text = "" + _elMensaje + ": " + leScore; //solo muestra el score, ya que no requiere tener un mínimo de nueces
        if (_pwrpuntos != 1)
        {
            frames++;
            if (frames >= 500)
            {
                _pwrpuntos = 1;
                frames = 0;
            }
        }//para que lso multiplicadores solo sean temporales
    }
}
