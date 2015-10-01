//using UnityEngine;
//using System.Collections;
//
//public class Pause : MonoBehaviour
//{
//    public bool ispaused; //para saber si estamos o no en pausa... no hay que se genio, es un bool y se llama ¿esta pausado?
//    // Use this for initialization
//    void Start()
//    {
//        ispaused = false;
//    }
//
//    void onGUI()
//    {
//        if(GUILayout.Button("PAUSE"))
//        {
//            if(!ispaused)
//            {
//                Time.timeScale = 0.0f;
//                ispaused = true;
//            }
//            else
//            {
//                Time.timeScale = 1.0f;
//                ispaused = false;
//            }
//        }
//    }
//}

using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public static bool paused;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.P)) {
						if (!paused) {
						
//			paused=true;
								OnApplicationPause (true);
				Time.timeScale = 0;
//			print("PENE");
						
						} else {
								OnApplicationPause (false);
				Time.timeScale=1;
//			print("despausa");
						}
				}
	}

	void OnGUI() {
		if (paused)
			GUI.Label(new Rect(600, 450, 500, 250), "Game paused");
		
	}
	void OnApplicationPause(bool pauseStatus) {
		paused = pauseStatus;
	}
}