using UnityEngine;
using System.Collections;

public class Fernanda : MonoBehaviour
{
    protected Animator animator;
    public static bool _muevoFerDer = false;
    public static bool _muevoFerIzq = false;
    public static bool _ferMuere = false;
    //private int goldenShower = Cubeta_Endless.regresameVidas();
    // Use this for initialization
    void Start()
    {
        _ferMuere = _muevoFerDer = _muevoFerIzq = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //	if(_muevoFerDer){
        //			animator.SetBool("corroo",true);
        //		}else{
        //			animator.SetBool("corroo",false);
        //
        //		}

        if (!_ferMuere)
        {
            if (_muevoFerDer)
            {
                animator.SetBool("correDerecha", true);
                animator.SetBool("correIzquierda", false);//cambia lso parametros del controller para que ponga la animacion correcta
            }
            else if (_muevoFerIzq)
            {
                animator.SetBool("correDerecha", false);
                animator.SetBool("correIzquierda", true);//cambia lso parametros del controller para que ponga la animacion correcta
                //transform.localScale.x = -transform.localScale.x;
            }
            else
            {
                animator.SetBool("correDerecha", false);//cambia lso parametros del controller para que ponga la animacion correcta
                animator.SetBool("correIzquierda", false);
            }
        }
        else
        {
            animator.SetBool("correDerecha", false);//cambia lso parametros del controller para que ponga la animacion correcta
            animator.SetBool("correIzquierda", false);
            animator.SetBool("muerta", true);// la animacion de fer meure
        }
    }
}
