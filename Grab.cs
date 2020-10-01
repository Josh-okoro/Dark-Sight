using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject torch;

    public Transform controller;

    public Rigidbody torchRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "torch")
        {
            torch.transform.SetParent(controller);
            torchRB.isKinematic = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "torch")
        {
            torch.transform.SetParent(null);
            torchRB.isKinematic = false;
        }
    }
}
