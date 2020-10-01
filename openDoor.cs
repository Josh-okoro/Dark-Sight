using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    
    public Animator DoorAnim;

    
    public AudioSource DoorSound;


    public GameObject ExitText;
    // Start is called before the first frame update
    void Start()
    {
       // DoorAnim = GetComponent<Animator>();
       // DoorSound = GetComponent<AudioSource>();

        DoorSound.enabled = false;
        DoorAnim.enabled = false;
        ExitText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            DoorAnim.enabled = true;
            DoorSound.enabled = true;
            DoorSound.loop = false;
            ExitText.SetActive(true);
        }
    }
}
