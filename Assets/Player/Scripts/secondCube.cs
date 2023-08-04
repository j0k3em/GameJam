using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secondCube : MonoBehaviour
{
    [SerializeField] private firstCube connectCubes;
    public int secondCounter = 1;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    private Image secondRenderer;

    // Start is called before the first frame update
    void Start()
    {
        connectCubes = FindObjectOfType<firstCube>();
        secondRenderer = GetComponent<Image>();

        if (secondRenderer == null)
        {
            secondRenderer.sprite = sprite1;
        }
    }

    public void ChangeSecondSquad()
    {
        if (secondRenderer.sprite == sprite1)
        {
            secondRenderer.sprite = sprite2;
            secondCounter++;
        }
        else if (secondRenderer.sprite == sprite2)
        {
            secondRenderer.sprite = sprite3;
            secondCounter++;
        }
        else if (secondRenderer.sprite == sprite3)
        {
            secondRenderer.sprite = sprite4;
            secondCounter++;
        }
        else if (secondRenderer.sprite == sprite4)
        {
            secondRenderer.sprite = sprite5;
            secondCounter++;
        }
        else if (secondRenderer.sprite == sprite5)
        {
            secondRenderer.sprite = sprite6;
            secondCounter++;
        }
        else
        {
            secondRenderer.sprite = sprite1;
            secondCounter -= 5;
        }

        connectCubes.CheckValue();
    }

    public int GetCounter() 
    { 
        return secondCounter;
    }

    //private void CheckValue()
    //{
    //    if ((firstCounter + secondCounter) == 6)
    //    {
    //        Debug.Log("win");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
