using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Code by Ankita Chakrabarti

    public Transform teleportTarget; // The variable for the teleport position
    public GameObject thePlayer; // The variable for the teleporting player

    void OnTriggerEnter(Collider other) // Setting thr trigger for teleportation
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        // The trigger makes one position equal to another
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
