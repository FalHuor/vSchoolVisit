using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBehaviour : MonoBehaviour {

	private LightsBehaviour LightsBehaviour;
	private bool isActive = false;
	private Transform textTransform;
	private Transform transform;
	private AudioSource audioSource;

	// Use this for initialization
	void Start()
	{
		transform = this.GetComponent<Transform>();
		LightsBehaviour = gameObject.GetComponentInParent<LightsBehaviour>();
		textTransform = transform.Find("Text");
		textTransform.gameObject.SetActive(false);
		audioSource = this.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		if (isActive)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				audioSource.Play();
				LightsBehaviour.ToggleLight();
				textTransform.GetComponent<Text>().text = LightsBehaviour.text;
			}
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			textTransform.GetComponent<Text>().text = LightsBehaviour.text;
			textTransform.gameObject.SetActive(true);
			isActive = true;
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			textTransform.gameObject.SetActive(false);
			isActive = false;
		}
	}
}
