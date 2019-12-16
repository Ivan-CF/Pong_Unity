using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidadY;
    public float maxY;
    private float posY;
    private float direction;

    public Transform ballPosition;

    // Update is called once per frame
    void Update()
    {
        if (ballPosition.position.y > transform.position.y)
        {
            direction = 1.0f;
        }
        else
        {
            direction = -1.0f;
        }

        posY = transform.position.y + direction * velocidadY * Time.deltaTime;

        if (posY > maxY)
        {
            posY = maxY;
        }
        else if (posY < -maxY)
        {
            posY = -maxY;
        }

        transform.position = new Vector3(transform.position.x, posY, transform.position.z);
    }
}