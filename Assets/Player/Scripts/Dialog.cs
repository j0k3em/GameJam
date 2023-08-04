using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject panelDialog;
    public Text dialog;
    public string[] message;
    public bool dialogStart = false;
    // Start is called before the first frame update
    void Start()
    {
        message[0] = "Привет";
        message[1] = "пройди дальше";
        panelDialog.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panelDialog.SetActive(true);
            dialog.text = message[0];
            dialogStart = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        panelDialog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogStart == true){
             if ( Input.GetKeyDown(KeyCode.R))
            {
                dialog.text = message[1];
            }
        }
    }
}
