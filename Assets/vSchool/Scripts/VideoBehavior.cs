using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoBehavior : MonoBehaviour {

	// Use this for initialization

	private VideoPlayer videoPlayer;
	private Camera camera;

	
	void Start () {
		videoPlayer = GetComponent<VideoPlayer>();
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
			Debug.DrawRay(camera.transform.position, camera.transform.forward * 5.0f, Color.yellow, 1.5f);
			RaycastHit hit;
			if(Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 5.0f))
            {
				if(hit.collider.tag == "VideoScreen")
                {
					if (videoPlayer.isPlaying)
					{
						videoPlayer.Pause();
					}
					else
					{
						videoPlayer.Play();
					}
				}
				
			}
            
        }
	}
}
