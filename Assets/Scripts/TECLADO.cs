using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TECLADO : MonoBehaviour
{
    public Transform body;
    public float speed, runspeed, walkspeed;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runspeed;
        }
        else
        {
            speed = walkspeed;
        }

        body.position += new Vector3(0f,0f,Input.GetAxis("Horizontal")) * speed * Time.deltaTime;
    }
}