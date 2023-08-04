using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstCube : MonoBehaviour
{
    [SerializeField] private secondCube connectCubes;
    public int firstCounter = 1;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    private Image firstRenderer;
    public static bool isSolved = false;

    void Start()
    {
        connectCubes = FindObjectOfType<secondCube>();
        firstRenderer = GetComponent<Image>();
        if (firstRenderer == null) 
        {
            firstRenderer.sprite = sprite1;
        }
    }

    public void ChangeFirstSquad() 
    {   
        if (firstRenderer.sprite == sprite1)
        {
            firstRenderer.sprite = sprite2;
            firstCounter++;
        }
        else if (firstRenderer.sprite == sprite2)
        {
            firstRenderer.sprite = sprite3;
            firstCounter++;
        }
        else if (firstRenderer.sprite == sprite3) 
        {
            firstRenderer.sprite = sprite4;
            firstCounter++;
        }
        else if (firstRenderer.sprite == sprite4) 
        {
            firstRenderer.sprite = sprite5;
            firstCounter++;
        }
        else if(firstRenderer.sprite == sprite5)
        {
            firstRenderer.sprite = sprite6;
            firstCounter++;
        }
        else
        {
            firstRenderer.sprite = sprite1;
            firstCounter -= 5;
        }
        CheckValue();
    }

    public void CheckValue() 
    {
        int secondCounter = connectCubes.GetCounter();
        if ((firstCounter + secondCounter) == 6) 
        {
            isSolved = true;
        }
    }

    private void Update()
    {
        isSolved = false;
    }


}
