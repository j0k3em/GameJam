using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeMenagment : MonoBehaviour
{
    public Text countCube;
    public GameObject cube;
    public int count = 0;
    private GameObject lastCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (countCube.text != "0")
            {
                lastCube = Instantiate(cube, position, Quaternion.identity) as GameObject;
                count = int.Parse(countCube.text);
                count--;
                UpdateCounterText();
            }
            else
            {

            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (lastCube != null) // проверяем, что последний созданный куб существует
            {
                Destroy(lastCube);
                count++;
                UpdateCounterText();
            }
        }
    }

    void UpdateCounterText()
    {
        countCube.text =  count.ToString();
    }
}
