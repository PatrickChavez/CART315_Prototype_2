using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturntoHub : MonoBehaviour
{
    // Reference from the Unity Forums
    // https://forum.unity.com/threads/teleport-player-from-clicking-ui-button.299328/

    public Transform teleportLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.P))
        {
            this.transform.position = teleportLocation.position;
        }
    }
}
