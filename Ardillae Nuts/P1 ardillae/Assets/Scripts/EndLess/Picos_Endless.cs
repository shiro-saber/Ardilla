using UnityEngine;
using System.Collections;

public class Picos_Endless : MonoBehaviour
{
    public Health health;
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
            //Puntos.leScore = 0;//resetemos lso puntos del jugador
            if (this.gameObject.name == "spikesI")//picos izquierda o derecha?
            {
                col.gameObject.transform.Translate(new Vector2(4f, 0f));// aventamos a fernanda lejos de los picos
                //Cubeta_Endless.vaginas -= 1;
            }
            else if (this.gameObject.name == "spikesD")
            {
                col.gameObject.transform.Translate(new Vector2(-4f, 0f));// aventamos lejos de los picos
                //Cubeta_Endless.vaginas -= 1;
            }
            //Destroy(GameObject.FindGameObjectWithTag("vida" + Cubeta_Endless.i.ToString()));
            //Cubeta_Endless.i++;
            //health.ModifyHealth(-10);
            ELvidas.cont = -1;
        }
    }
}
