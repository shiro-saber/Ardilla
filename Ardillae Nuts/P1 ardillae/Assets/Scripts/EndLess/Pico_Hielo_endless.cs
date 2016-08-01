using UnityEngine;
using System.Collections;

public class Pico_Hielo_endless : MonoBehaviour
{
    private int picamela = 0;
    private int randi = 0;
    private Vector2 tutzke;
    public GameObject warning;
    private int frames = 0;
    private int salPico = 0;
    public Health health;
    private Vector2 posini = new Vector2(-23.86018f, -0.552273f);
    // Use this for initialization
    void Start()
    {
        //picamela = Random.Range(0, 10000);
    }

    // Update is called once per frame
    void Update()
    {
        picamela = Random.Range(-11, 17);
        randi = Random.Range(0, 1000);


        // this.transform.position=(new Vector2(picamela , -8.6f));
        // Mathf.Lerp(transform.position.x, player.position.x, 8f * Time.deltaTime);
        if (randi % 666 == 0)
        {
            this.transform.position = (new Vector2(picamela, -10.6f));
            //this.transform.Translate(new Vector2(0f, 2.467f));
            //			print("SALE PICO");
            tutzke = this.transform.position;
            //print("sellamo");
            frames++;
        }

        if (frames >= 1)
        {
            warning.transform.position = new Vector2(tutzke.x, -1f);
            frames++;
            //print(frames);
            if (frames > 70)
            {
                frames = 0;

                this.transform.Translate(new Vector2(0f, 4.467f));
            }
        }
        //print(this.transform.position.y);
        if (this.transform.position.y > -7f)
        {
            //print("hola");
            salPico++;
            if (salPico > 50)
            {
                //				print ("REGRESA PICO");
                warning.transform.position = posini;
                this.transform.Translate(new Vector2(0f, -4.467f));
                salPico = 0;
            }
        }

    }
    //	int xxx=0;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Collider2D zain = col.collider; //kguardar el collider el jugador 
            //print(zain.name);print(zain.tag);
            //sacamos los vectores de la colision para comparar y empujarsela a fer
            Vector3 abdul = col.contacts[0].point;//punto en el que hizo contacto
            Vector3 mohammed = zain.bounds.center;
            if(abdul.x < mohammed.x)
            {
                //empujar a la derecha
                //print("derecha");
                col.gameObject.transform.Translate(new Vector2(2f, 0f));
            }
            else if(abdul.x > mohammed.x)
            {
                //empujar a la izquierda
                //print("izquierda");
                col.gameObject.transform.Translate(new Vector2(-2f, 0f));
            }
            ELvidas.cont -= 1;
        }
    }

    //void salePico()
    //{
    //    //print(tutzke);
    //    warning.transform.position = new Vector2(tutzke.x, -1f);
    //    frames++;
    //    print(frames);
    //    if (frames > 50)
    //    {
    //        warning.transform.position = posini;
    //        frames = 0;
    //    }

    /*
     * max y= -6.133299
     * min y= -8.595798
     * dif=2.467
     * izq=-11
     * der = 17
     * warning = pos y = -1
     * */

}
