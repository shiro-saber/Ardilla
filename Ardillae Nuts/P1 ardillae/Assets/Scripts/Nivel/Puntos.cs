using UnityEngine;
using System.Collections;

public class Puntos : MonoBehaviour
{
    public static int _puntos = 0;
    public static int _pwrpuntos;
    public static string _elMensaje;
    private int frames = 0;
    public static int leScore;
    // Use this for initialization
    void Start()
    {
        _pwrpuntos = 1;
        _elMensaje = "Nueces: ";
        leScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //leScore+= (_puntos*_pwrpuntos);
        leScore += _puntos;
        //print ("puntos "+_puntos);
        //print ("multiplayer"+_pwrpuntos);
        _puntos = 0;
        //le score es la variable que acumula los puntos
        //reseteamos _puntos para que no se sumen infinitamente los puntos obtenidos 
		this.GetComponent<GUIText>().text = "" + _elMensaje + ": " + leScore + "/"+ PlayerPrefs.GetInt("minNuez");
        //this.guiText.text = ""+ _elMensaje + _puntos*_pwrpuntos;
        if (_pwrpuntos != 1)
        {
            frames++;
            if (frames >= 300)
            {
                _pwrpuntos = 1;
                frames = 0;
            }
        }//para que lso multiplicadores solo sean temporales 
    }
}
