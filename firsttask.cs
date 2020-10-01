using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firsttask : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private GameObject firstTaskText;

    [SerializeField]
    private GameObject SecondTaskText;
    bool SecondTask = false;
    // Start is called before the first frame update
    void Start()
    {
        firstTaskText = GameObject.FindGameObjectWithTag("firstTask");
        SecondTaskText = GameObject.FindGameObjectWithTag("secondTask");

        SecondTaskText.SetActive(false);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //turn off first mission text
        if ((rb.isKinematic == true) && (SecondTask == false))
        {
            firstTaskText.SetActive(false);
            SecondTask = true;
        }

        if (SecondTask == true)
        {
            SecondTaskText.SetActive(true);
            SecondMission();
            //StartCoroutine(SecondMission());

        }
    }

    IEnumerator SecondMission()
    {
        yield return new WaitForSeconds(10f);
        SecondTaskText.SetActive(false);
    }

    IEnumerator SecondMissionForceStopScript()
    {
        yield return new WaitForSeconds(10f);
        SecondTaskText.SetActive(false);
        SecondTask = false;
    }
}
