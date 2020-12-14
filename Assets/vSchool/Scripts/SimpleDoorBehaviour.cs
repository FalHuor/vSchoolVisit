using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDoorBehaviour : MonoBehaviour {

    public List<string> TagsActivation;
    private Animator animator;
    AudioSource[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSources = GetComponents<AudioSource>();
        TagsActivation.Add("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TagsActivation.Contains(other.tag))
        {
            PlayOpenAnimation();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (TagsActivation.Contains(other.tag))
        {
            PlayCloseAnimation();
        }
    }

    private void PlayOpenAnimation()
    {
        audioSources[0].Play();
        animator.Play("open_door");
    }

    private void PlayCloseAnimation()
    {
        audioSources[1].Play();
        animator.Play("close_door");
    }
}
