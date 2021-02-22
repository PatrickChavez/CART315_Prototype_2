using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Code by Ankita Chakrabarti

    public Transform teleportTarget; // The variable for the teleport position
    public GameObject thePlayer; // The variable for the teleporting player
    private AudioSource soundEffect;

    void OnTriggerEnter(Collider other) // Setting the trigger for teleportation
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        // The trigger makes one position equal to another
        soundEffect.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        soundEffect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
