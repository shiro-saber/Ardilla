using UnityEngine;
using System.Collections;

public class camara_movimiento : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    private float LockedY = -0.239f;
    private float LockedZ = -1.5f;
	private Vector3 vec;
	Matrix4x4 matriz;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		matriz = GetComponent<Camera>().cameraToWorldMatrix;

		if(( -15  <= player.transform.position.x) && (11 >= player.transform.position.x))         
        transform.position = new Vector3(player.transform.position.x, LockedY, LockedZ); //mueve la camara con respecto a la posicion del jugador en X
    }
}