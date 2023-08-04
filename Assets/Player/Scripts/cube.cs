using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    public static int updateCount = 0;
    public GameObject questCube;
    public static int cubesCounter = 0;
    public Text counter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (updateCount == 0)
        {
            if (firstCube.isSolved)
            {   
                GameObject newCube = Instantiate(questCube, new Vector2(934, 310), Quaternion.identity) as GameObject;
                Destroy(newCube, 2f);
                cubesCounter++;
                updateCount++;
                counter.text = cubesCounter.ToString();
            }
        }      
    }
}
