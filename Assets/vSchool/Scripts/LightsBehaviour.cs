using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsBehaviour : MonoBehaviour {

	private List<GameObject> switchs = new List<GameObject>();
	private Transform transform;
	public bool LightsUp = false;
	private bool isActive = false;

	// Use this for initialization
	void Start () {
		transform = this.GetComponent<Transform>();
		foreach (Transform child in transform)
		{
			if (child.gameObject.tag == "Switch")
			{
				switchs.Add(child.gameObject);
				Debug.Log(child.gameObject.name);
			}
		}
		Debug.Log(switchs.Count);
	}
	
	// Update is called once per frame
	void Update () {
		if (isActive)
        {
			if (Input.GetButton("Fire1"))
			{
				if (LightsUp == false)
				{
					LightsUp = true;

				}
				else if (LightsUp == true)
				{
					LightsUp = false;
				}
			}
		}
	}

	void OnCollisionEnter(Collision collision)
	{
        if (collision.collider.CompareTag("Player"))
        {
			isActive = true;

		}
	}

	void OnCollisionExit(Collision collision)
	{
		if (collision.collider.CompareTag("Player"))
		{
			isActive = false;
		}
	}
}
