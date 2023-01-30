using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour{

    //movement
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float speed;
    Vector2 movement;

    public float rotationSpeed = 15f;

    public void OnEnable(){

    }

    // Update is called once per frame
    public void Update(){
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");
        gameObject.transform.Translate((Vector3.up * moveSpeed) * Time.deltaTime);

        gameObject.transform.Rotate((new Vector3(0, 0, 10) * rotationSpeed) * Time.deltaTime);

        //faceMouse();
    }

    //void faceMouse(){
    //    Vector3 mousePosition = Input.mousePosition;
    //    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            
    //    Vector2 direction = new Vector2(
    //        mousePosition.x - transform.position.x,
    //        mousePosition.y - transform.position.y
    //        );

    //    transform.up = direction;
    //}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
