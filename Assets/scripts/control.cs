using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public float maxX;
    Vector3 position;
    float input;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        input = Input.GetAxis("Horizontal");
        if (input < 0)
        {
            MoveLeft();
        }
        else if (input > 0)
        {
            MoveRight();

        }
        else if (input == 0)
            Stop();

        position = transform.position;
        position.x = Mathf.Clamp(position.x, -maxX, maxX);//limit the min and max values of the platform
        transform.position = position;
    }
    void FixedUpdate()
    {
        
    }

    void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }
    
    void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    
    void Stop()
    {
        rb.velocity = Vector2.zero;
    }
}
