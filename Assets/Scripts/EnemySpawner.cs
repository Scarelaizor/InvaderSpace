using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public float rate = 5F;

    private float maxX = 1.85F;
    private float minX = -1.85F;

    private float counter;

    private void Start()
    {
        counter = rate;
    }

    // Update is called once per frame
    void Update()
    {

        if (!GameManager.isRunning())
            return;

        if (counter <= 0)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPos = new Vector2(randomX, 4);

            Instantiate(enemy, spawnPos, Quaternion.identity);

            counter = rate;
        }
        else
            counter = counter - Time.deltaTime;



    }



}
