using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        //W
        if (Input.GetKey(KeyCode.W))
        {
            dir += Vector3.up;
        }

        //A
        if (Input.GetKey(KeyCode.A))
        {
            dir += Vector3.left;
        }

        //S
        if (Input.GetKey(KeyCode.S))
        {
            dir += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir += Vector3.right;
        }

        this.transform.Translate(dir.normalized * speed * Time.deltaTime);
    }
}
