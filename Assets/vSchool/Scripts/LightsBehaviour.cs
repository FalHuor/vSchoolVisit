using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsBehaviour : MonoBehaviour {

	private List<GameObject> switchs = new List<GameObject>();
	private List<GameObject> lights = new List<GameObject>();
	private Transform transform;
	public bool LightsUp = false;

	// Use this for initialization
	void Start () {
		transform = this.GetComponent<Transform>();
		foreach (Transform child in transform)
		{
			if (child.gameObject.tag == "Switch")
			{
				switchs.Add(child.gameObject);
			}
		}
		foreach (Transform child in transform.Find("Lights"))
		{
			if (child.gameObject.tag == "Lights")
			{
				lights.Add(child.gameObject);
			}
		}
		foreach (GameObject light in lights)
        {
			if (LightsUp)
            {
				light.GetComponent<Light>().intensity = 1;
            } 
			else
            {
				light.GetComponent<Light>().intensity = 0;
			}
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleLight()
    {
		LightsUp = !LightsUp;
		foreach (GameObject light in lights)
		{
			if (LightsUp)
			{
				light.GetComponent<Light>().intensity = 1;
			}
			else
			{
				light.GetComponent<Light>().intensity = 0;
			}
		}
		Debug.Log("State of lights : " + LightsUp);
	}
}
