using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public GameObject imageQuest;
    public bool questStart = false;

    void Start()
    {
        imageQuest.SetActive(false);
    }

    void Update()
    {
        if (firstCube.isSolved == true) 
        {
            imageQuest.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            imageQuest.SetActive(true);
            questStart = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        imageQuest.SetActive(false);
    }
}
