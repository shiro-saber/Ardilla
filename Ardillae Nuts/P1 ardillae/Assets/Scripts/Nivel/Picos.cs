using UnityEngine;
using System.Collections;

public class Picos : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Puntos.leScore = 0;//resetemos lso puntos del jugador
            if (this.gameObject.name == "spikesI")//picos izquierda o derecha?
            {
                col.gameObject.transform.Translate(new Vector2(4f, 0f));// aventamos a fernanda lejos de los picos
            }
            else if (this.gameObject.name == "spikesD")
            {
                col.gameObject.transform.Translate(new Vector2(-4f, 0f));// aventamos lejos de los picos
            }
        }
    }
}
