using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public string pickuptag;
    public Text textComponent;
    int score = 0;
    // Audio code from Statement and levelzerozilch 
    public AudioSource[] sounds;
    public AudioSource noise1;
    public AudioSource noise2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(pickuptag))
        {
            Debug.Log("Collision detected with pickup");
            noise2.Play();
            Destroy(collision.collider.gameObject);

            score = score + 1;
            textComponent.text = "Cubes: " + score;
        }
    }

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
        
    }
}
