using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public float xMargin = 1f;		// Distance in the x axis the player can move before the camera follows.
    public float yMargin = 1f;		// Distance in the y axis the player can move before the camera follows.
    public float xSmooth = 8f;		// How smoothly the camera catches up with it's target movement in the x axis.
    public float ySmooth = 8f;		// How smoothly the camera catches up with it's target movement in the y axis.
    public Vector2 maxXAndY;		// The maximum x and y coordinates the camera can have.
    public Vector2 minXAndY;		// The minimum x and y coordinates the camera can have.
    private Transform player;		// Reference to the player's transform.

    void Awake()
    {
        // Setting up the reference.
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    bool CheckXMargin()
    {
        // Returns true if the distance between the camera and the player in the x axis is greater than the x margin.
        return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
    }


    bool CheckYMargin()
    {
        // Returns true if the distance between the camera and the player in the y axis is greater than the y margin.
        return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
    }


    void FixedUpdate()
    {
        TrackPlayer();
    }


    void TrackPlayer()
    {
        // By default the target x and y coordinates of the camera are it's current x and y coordinates.
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        // If the player has moved beyond the x margin...
        if (CheckXMargin())
            // ... the target x coordinate should be a Lerp between the camera's current x position and the player's current x position.
			targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);

        // If the player has moved beyond the y margin...
        if (CheckYMargin())
            // ... the target y coordinate should be a Lerp between the camera's current y position and the player's current y position.
            targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);

        // The target x and y coordinates should not be larger than the maximum or smaller than the minimum.
        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x) - 0.4f;
        targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);
		//print (targetX + "\t" + player.position.x);
        // Set the camera's position to the target position with the same z component.
        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }


//	void OnMouseDown() {
//				mPos = Input.mousePosition;
//				print (mPos.x);
//				print (scrnW);
//				if (mPos.x > scrnW) {
//						fer.transform.Translate (new Vector3 (0.2f * Mover._spdMult, 0, 0));
//			
//						//			transform.Translate (Vector3.right * _spdMult * Time.deltaTime);
//						//			animator.SetBool("corroo",true);
//						//			rigidbody2D.velocity = new Vector2(1.3f,0f);
//						//rigidbody2D.MovePosition(rigidbody2D.position + speed * _spdMult);
//			
//						Fernanda._muevoFerDer = true;//controladores para la animacion 
//						Fernanda._muevoFerIzq = false;
//						//print("muevo");
//
//				} else if (mPos.x < scrnW) {
//						fer.transform.Translate (new Vector3 (-0.2f * Mover._spdMult, 0, 0));
//			
//						//			transform.Translate (Vector3.left * _spdMult * Time.deltaTime);
//						//			animator.SetBool("corroo",true);
//						//			rigidbody2D.velocity = new Vector2(-1.3f,0f);
//						//rigidbody2D.MovePosition(rigidbody2D.position - speed * _spdMult);
//			
//						Fernanda._muevoFerIzq = true;//controladores para la animacion 
//						Fernanda._muevoFerDer = false;
//						//print("muevo");
//				}
//
//		}

}
