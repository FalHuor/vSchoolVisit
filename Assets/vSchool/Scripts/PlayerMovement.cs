using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed = 5.0f;
    public float Gravity = -14.0f;
    public float JumpForce = 5f;

    private CharacterController characterController;
    private Vector3 movement;
    private float verticalForce;
	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal") * Speed, verticalForce, Input.GetAxis("Vertical") * Speed);
        movement = transform.TransformDirection(movement);
        characterController.Move(movement * Time.deltaTime);

        if (characterController.isGrounded)
        {
            verticalForce = 0;
        }
        else
        {
            verticalForce += Gravity * Time.deltaTime;
        }

        if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            verticalForce = JumpForce;
        }
        
    }
}
