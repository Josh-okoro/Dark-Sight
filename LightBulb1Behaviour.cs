using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb1Behaviour : MonoBehaviour
{   
    [SerializeField]
    private GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectWithTag("light");
        StartCoroutine(lightsOne());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator lightsOne()
    {
        yield return new WaitForSeconds(12f);
        lights.SetActive(false);
    }
}
