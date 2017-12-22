using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charct : MonoBehaviour {


    private float speed = 0.5f;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);

        transform.Translate(movement * speed);

    }

    void Jump()
    {
       

    }

}
