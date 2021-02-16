using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicScript : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 2.0f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            this.GetComponent<Transform>().Rotate(rotation);
        }
        
    }
}
