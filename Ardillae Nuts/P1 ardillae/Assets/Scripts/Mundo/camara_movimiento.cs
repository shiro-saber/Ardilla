using UnityEngine;
using System.Collections;

public class camara_movimiento : MonoBehaviour {

	// Use this for initialization
    //public int DistanceAway = 10;
    public GameObject player;
    private float LockedY = -0.239f;
    private float LockedZ = -1.5f;
	private Vector3 vec;
	Matrix4x4 matriz;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 PlayerPOS = GameObject.Find("Player").transform.transform.position;
        //GameObject.Find("MainCamera").transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - DistanceAway);

		//if(player.transform.position.x > -10 && player.transform.position.x > 15)
		//print (Screen.width);
		//print (camera.rect);
		//vec = camera.ScreenToWorldPoint;
		//print (camera.pixelWidth);
		matriz = GetComponent<Camera>().cameraToWorldMatrix;
//		print (matriz);
		if(( -15  <= player.transform.position.x) && (11 >= player.transform.position.x))
		{
         
        transform.position = new Vector3(player.transform.position.x, LockedY, LockedZ);//mueve la camara con respecto ala osicion del jugador en X
		}
    }
}