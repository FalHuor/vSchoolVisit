using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour {

	private LightsBehaviour LightsBehaviour;

	// Use this for initialization
	void Start()
	{
		LightsBehaviour = GameObject.Find("Ceiling_lights").GetComponent<LightsBehaviour>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.CompareTag("Player"))
		{

		}
	}

	void OnCollisionExit(Collision collision)
	{
		if (collision.collider.CompareTag("Player"))
		{
			/*LightsBehaviour.isActive = false;
			Debug.Log(LightsBehaviour.isActive);*/
		}
	}
}
