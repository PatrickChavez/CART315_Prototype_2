using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturntoHub : MonoBehaviour
{
    // Reference from the Unity Forums
    // https://forum.unity.com/threads/teleport-player-from-clicking-ui-button.299328/

    public Transform teleportLocation;
    // Audio code from Statement and levelzerozilch 
    public AudioSource[] sounds;
    public AudioSource noise1;
    public AudioSource noise2;

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
        noise2 = sounds[1];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.P))
        {
            this.transform.position = teleportLocation.position;
            noise1.Play();
        }
    }
}
