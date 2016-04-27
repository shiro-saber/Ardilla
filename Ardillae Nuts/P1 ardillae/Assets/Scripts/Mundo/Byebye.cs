using UnityEngine;
using System.Collections;

public class Byebye : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown() // esta funcion detecta el click para darle fin a la aplicacion.
    {
        //print("se clikeo"); // esto es una prueba de que el colider esta funcionando
        Application.Quit();

    }


}
