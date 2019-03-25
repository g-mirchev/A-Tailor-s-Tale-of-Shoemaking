using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour		// integrated from this video https://www.youtube.com/watch?v=blO039OzUZc
{
	public float speed = 10.0F;
    // Lock the cursor upon start
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // moving frint and back uses translation while sideways uses strafle for a more realistic feeling
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
		float straffe = Input.GetAxis("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;
		
		transform.Translate(straffe, 0, translation);
		
		if (Input.GetKeyDown("escape"))
		{
			Cursor.lockState = CursorLockMode.None;
		}	
    }
}
