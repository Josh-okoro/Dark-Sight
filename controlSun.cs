using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlSun : MonoBehaviour
{
    public Light Sun;
    public GameObject AmbientSounds;
    // Start is called before the first frame update
    void Start()
    {
        Sun.intensity = 0;
        AmbientSounds.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Sun.intensity = 1;
            AmbientSounds.SetActive(true);
        }
    }
}
