using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed = 5.0f;
    public float Gravity = -14.0f;
    private CharacterController characterController;
    private Vector3 movement;
	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal") * Speed, 0, Input.GetAxis("Vertical") * Speed);
        movement = transform.TransformDirection(movement);
        characterController.Move(movement * Time.deltaTime);
	}
}
