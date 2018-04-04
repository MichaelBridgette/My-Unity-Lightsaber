using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberSound : MonoBehaviour {


    public AudioSource audioSource;
    public AudioClip on;
    public AudioClip off;
    public AudioClip hum;
    bool isOn = true;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isOn)
            {
                audioSource.loop = false;
                isOn = false;
                audioSource.Stop();
                audioSource.clip = off;
                audioSource.Play();
                Debug.Log("OFF");
            }
            else
            {
                audioSource.loop = false;
                isOn = true;
                audioSource.Stop();
                audioSource.clip = on;
                audioSource.Play();
                Debug.Log("ON");
            }
        }
        if(isOn && !audioSource.isPlaying)
        {
            audioSource.clip = hum;
            audioSource.Play();
            audioSource.loop = true;
        }

	}
}
