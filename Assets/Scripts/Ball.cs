using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector2 ballPosition;
    public Vector2 ballVelocity;

    void Awake()
    {
        ballPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ballPosition.y = transform.position.y + ballVelocity.y * Time.deltaTime;
        ballPosition.x = transform.position.x + ballVelocity.x * Time.deltaTime;

        transform.position = new Vector3(ballPosition.x, ballPosition.y, transform.position.z);
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Muro")
        {
            ballVelocity.y *= -1;
        }
        else if (other.gameObject.tag == "EnemyGoal")
        {
            Debug.Log("Hemos marcado un gol");
            transform.position = new Vector3(0, 0, 0);
            ballVelocity.x = -3;
            ballVelocity.y = -2;
        }
        else if (other.gameObject.tag == "PlayerGoal")
        {
            Debug.Log("Eres un paquete");
            transform.position = new Vector3(0, 0, 0);
            ballVelocity.x = 3;
            ballVelocity.y = 2;
        }
        else if (other.gameObject.tag == "Pala")
        {
            ballVelocity.x *= -1.2f;
            ballVelocity.y *= 1.2f;
        }
    }


}