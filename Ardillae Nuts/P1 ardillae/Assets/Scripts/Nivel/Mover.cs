using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public static float _spdMult = 1f;
    private int frames = 0;

//    private Vector2 speed = new Vector2(0.3f, 0);
//    private Vector2 salto = new Vector2(0f, 3f);

	//private Vector2 mPos= new Vector2(0f,0f);
	private float scrnW;

    // Use this for initialization
    void Start()
    {
		scrnW = Screen.width/2;
        //_spdMult = 10f;
        //print (_spdMult);


    }

    // Update is called once per frame
    void Update()
    {
        //funciones para mover a fernanda
		if (Input.GetKey(KeyCode.RightArrow) || (Input.GetMouseButton(0) && Input.mousePosition.x > scrnW))
        {
            transform.Translate(new Vector3(0.2f * _spdMult, 0, 0));

            //			transform.Translate (Vector3.right * _spdMult * Time.deltaTime);
            //			animator.SetBool("corroo",true);
            //			rigidbody2D.velocity = new Vector2(1.3f,0f);
            //rigidbody2D.MovePosition(rigidbody2D.position + speed * _spdMult);

            Fernanda._muevoFerDer = true;//controladores para la animacion 
            Fernanda._muevoFerIzq = false;
            //print("muevo");

        }
		else if (Input.GetKey(KeyCode.LeftArrow)|| (Input.GetMouseButton(0) && Input.mousePosition.x < scrnW))
        {
            transform.Translate(new Vector3(-0.2f * _spdMult, 0, 0));

            //			transform.Translate (Vector3.left * _spdMult * Time.deltaTime);
            //			animator.SetBool("corroo",true);
            //			rigidbody2D.velocity = new Vector2(-1.3f,0f);
            //rigidbody2D.MovePosition(rigidbody2D.position - speed * _spdMult);

            Fernanda._muevoFerIzq = true;//controladores para la animacion 
            Fernanda._muevoFerDer = false;
            //print("muevo");
        }
        else
        {
            //print("idle");
            Fernanda._muevoFerDer = false;//controladores para la animacion 
            Fernanda._muevoFerIzq = false;
            //			animator.SetBool("corroo",false);
            //regresar a idle
        }
//        if (Input.GetKeyDown(KeyCode.UpArrow))
//        {
//            if (grounded())
//            {
//                print("deberia saltar");
//                //transform.Translate (Vector3.up * Time.deltaTime*200);
//                //rigidbody2D.AddForce (new Vector2(0f,1000f));
//                //rigidbody2D.AddRelativeForce( salto);
//                //transform.rigidbody2D.AddForce (salto);
//                //rigidbody2D.position=rigidbody2D.position + salto;
//                //rigidbody2D.velocity= salto;
//
//            }
//        }

        //print (_spdMult);

        if (_spdMult != 1)
        {
            frames++;
            if (frames >= 500)
            {
                _spdMult = 1f;
                frames = 0;
            }
        }//para que lso multiplicadores solo sean temporales 


    }
	
//	void OnMouseDown() {
//		mPos = Input.mousePosition;
//		print (mPos.x);
//		print (scrnW);
//		if (mPos.x > scrnW)
//		{
//			transform.Translate(new Vector3(0.2f * _spdMult, 0, 0));
//			
//			//			transform.Translate (Vector3.right * _spdMult * Time.deltaTime);
//			//			animator.SetBool("corroo",true);
//			//			rigidbody2D.velocity = new Vector2(1.3f,0f);
//			//rigidbody2D.MovePosition(rigidbody2D.position + speed * _spdMult);
//			
//			Fernanda._muevoFerDer = true;//controladores para la animacion 
//			Fernanda._muevoFerIzq = false;
//			//print("muevo");
//			
//		}
//		else if (mPos.x<scrnW)
//		{
//			transform.Translate(new Vector3(-0.2f * _spdMult, 0, 0));
//			
//			//			transform.Translate (Vector3.left * _spdMult * Time.deltaTime);
//			//			animator.SetBool("corroo",true);
//			//			rigidbody2D.velocity = new Vector2(-1.3f,0f);
//			//rigidbody2D.MovePosition(rigidbody2D.position - speed * _spdMult);
//			
//			Fernanda._muevoFerIzq = true;//controladores para la animacion 
//			Fernanda._muevoFerDer = false;
//			//print("muevo");
//		}
//
//
//	}


}
