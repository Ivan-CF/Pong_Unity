using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadY;
    private float posY;
    private float direction;
    private Vector3 newPosition = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {

        direction = Input.GetAxis("Vertical");

        Debug.Log(transform.position.y);
        Debug.Log(transform.rotation.y);

        posY = transform.position.y + direction * velocidadY * Time.deltaTime;

        if (posY <= -4.20f)
        {
            posY = -4.20f;
        }

        if (posY >= 4.278f)
        {
            posY = 4.278f;
        }
        

        newPosition.x = transform.position.x;
        newPosition.y = posY;
        newPosition.z = transform.position.z;
        transform.position = newPosition;

        
    }
}