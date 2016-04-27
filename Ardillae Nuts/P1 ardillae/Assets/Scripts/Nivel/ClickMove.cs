using UnityEngine;
using System.Collections;

public class ClickMove : MonoBehaviour {
	private Vector2 mPos= new Vector2(0f,0f);
	private float scrnW;
	// Use this for initialization
	void Start () {
		scrnW = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public Texture btnTexture;
	void OnGUI() {
		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		if (GUI.Button(new Rect(10, 10, 50, 50), btnTexture))
			Debug.Log("Clicked the button with an image");
		
		if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
			Debug.Log("Clicked the button with text");
		
	}


	void OnMouseDown() {
		mPos = Input.mousePosition;
		print (mPos.x);
		print (scrnW);
		if (mPos.x > scrnW)
		{
			transform.Translate(new Vector3(0.2f * Mover._spdMult, 0, 0));
			Fernanda._muevoFerDer = true;//controladores para la animacion 
			Fernanda._muevoFerIzq = false;
		}
		else if (mPos.x<scrnW)
		{
			transform.Translate(new Vector3(-0.2f * Mover._spdMult, 0, 0));
			Fernanda._muevoFerIzq = true;//controladores para la animacion 
			Fernanda._muevoFerDer = false;
		}
	}
}
