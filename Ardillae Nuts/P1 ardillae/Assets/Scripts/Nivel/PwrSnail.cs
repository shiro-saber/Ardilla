using UnityEngine;
using System.Collections;

public class PwrSnail : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -3)
        {

            //print ("hola");
            Destroy(this.gameObject);
        }//si el objeto llega al final del escenario (en y) es destruido)
    }
}
