using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Projectile Stuff")]
    public GameObject projectile;
    public Vector3 position;

    [Header("Stats")]
    public float rate = 10;

    private float counter;

    void Start()
    {

        counter = rate;

    }

    // Update is called once per frame
    void Update()
    { 

        if (counter <= 0)
        {
            //Shoot
            Vector3 newPos = new Vector3(transform.position.x, position.y);
            Instantiate(projectile, newPos, Quaternion.identity);

            counter = rate;
        }
        else
            counter = counter - Time.deltaTime;

    }
}
