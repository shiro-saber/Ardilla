using UnityEngine;
using System.Collections;

public class Explo : MonoBehaviour
{
    private Vector3 posi = new Vector3(-11.60591f, 12.50894f, 0f);
    private int frames = 0;
    // Use this for initialization
    void Start()
    {

    }
    /*
     * pos animacion 
     * x=-11.60591
     * y=12.50894
     * z=0
     */
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position != posi)
        {
            frames++;
            if (frames >= 20)
            {
                frames = 0;
                this.transform.position = posi;
            } //llama la animacion de la explosion
        }
    }
}
