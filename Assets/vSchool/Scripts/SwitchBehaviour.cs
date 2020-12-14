using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour {

	private LightsBehaviour LightsBehaviour;
	private bool isActive = false;

	// Use this for initialization
	void Start()
	{
		LightsBehaviour = gameObject.GetComponentInParent<LightsBehaviour>();
	}

	// Update is called once per frame
	void Update()
	{
		if (isActive)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				LightsBehaviour.ToggleLight();
			}
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			isActive = true;
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			isActive = false;
		}
	}
}
