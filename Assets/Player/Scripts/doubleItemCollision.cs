using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleItemCollision : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;

    private bool item1Collided = false;
    private bool item2Collided = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == item1)
        {
            item1Collided = true;
        }

        if (collision.gameObject == item2)
        {
            item2Collided = true;
        }

        if (item1Collided && item2Collided)
        {
            Debug.Log("Both items collided!");
            // Добавьте свой код здесь, который будет выполняться при одновременном столкновении обоих предметов
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == item1)
        {
            item1Collided = false;
        }

        if (collision.gameObject == item2)
        {
            item2Collided = false;
        }
    }
}