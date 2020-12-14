using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    public enum RotationAxis
    {
        X = 1,
        Y = 2
    }
    public RotationAxis Axes = RotationAxis.X;
    public float SensHorizontal = 5.0f;
    public float SensVertical = 5.0f;
    public float MinimumVerticalAngle = -75.0f;
    public float MaximumVerticalAngle = 55.0f;

    private float rotationX = 0;
    private float rotationY = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Axes == RotationAxis.X)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensHorizontal, 0);
        }
        else if (Axes == RotationAxis.Y)
        {
            rotationX -= Input.GetAxis("Mouse Y") * SensVertical;
            rotationX = Mathf.Clamp(rotationX, MinimumVerticalAngle, MaximumVerticalAngle);
            rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
    }
}
