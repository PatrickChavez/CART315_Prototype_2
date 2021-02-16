using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTriggerScript : MonoBehaviour
{
    // Script code from Dekoba 
    public MovingPlatformScript platform;

    private void OnTriggerEnter(Collider other)
    {
        platform.NextPlatform();
    }
}
