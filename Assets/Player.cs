using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movementSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 speed = new Vector2(0, 0);
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            speed.y += 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed.y += -1;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed.x += 1;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed.x += -1;
        }
        speed.Normalize();
        speed *= movementSpeed * Time.fixedDeltaTime;
        transform.position += (Vector3)speed;
    }
}
