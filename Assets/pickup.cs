using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public string pickuptag;
    public Text textComponent;
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(pickuptag))
        {
            Debug.Log("Collision detected with pickup");
            Destroy(collision.collider.gameObject);

            score = score + 1;
            textComponent.text = "Cubes: " + score;
        }
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
