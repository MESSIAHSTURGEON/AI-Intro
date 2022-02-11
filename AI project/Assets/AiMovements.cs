using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovements : MonoBehaviour
{
    
    public GameObject position0;
    public GameObject position1;

    //transform.position.x = 4
    //AiPosition.X = 5

    private void Update()
    {
        Vector2 AiPosition = transform.position;

         transform.position = Vector2.MoveTowards(transform.position,
           position0.transform.position,
           Time.deltaTime);

        if (transform.position.x < position0.transform.position.x)
        {
            AiPosition.x += (1 * Time.deltaTime);
            transform.position = (Vector3)AiPosition;
        }
        else
        {
            AiPosition.x -= (1 * Time.deltaTime);
            transform.position = (Vector3)AiPosition;
        }
        
        if (transform.position.y < position0.transform.position.y)
        {
            transform.position += Vector3.up * 1 * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.up * 1 * Time.deltaTime;
        }
    }
}
