using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [Header("Attributes")]
    public float speed;
    public float distance;

    private float counter;


    void Start()
    {
        counter = speed;

    }

    // Update is called once per frame
    void Update()
    {

        if (counter <= 0)
        {
            Move();

            counter = speed;
        }
        else
            counter = counter - Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            TakeDamage();

        }

    }



    private void TakeDamage()
    {
        if (!GameManager.isRunning())
            return;

        Destroy(gameObject);
        GameManager.GainPoint();
    }

    private void Move()
    {
        int dir = Random.Range(0, 3);

        if (dir == 0) //forward
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - distance, transform.position.z);

            if (transform.position.y <= -2) //-2 is the y position of the player
                GameManager.Lose();

        }
        else if (dir == 1) //left
        {
            if (transform.position.x - distance > -1.85) //the screen width is from -1.85 to 1.85
                transform.position = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
        }
        else if (dir == 2) //right 
        {
            if (transform.position.x + distance < 1.85) //the screen width is from -1.85 to 1.85
                transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
        }

    }




}
