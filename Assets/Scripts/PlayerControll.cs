using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!GameManager.isRunning())
            return;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector3 touchPosition = Input.GetTouch(0).position;

            //Check if it's the left or right side of the screen?
            if (touchPosition.x < Screen.width/2)
            { 
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else if (touchPosition.x > Screen.width/2)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

        }
    }

}
