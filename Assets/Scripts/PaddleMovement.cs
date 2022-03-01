using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] float worldSize = 13.33333f;
    [SerializeField] float paddleWidth = 2.56f;
    void Update()
    {
        float mousepos = Input.mousePosition.x / Screen.width * worldSize;
        Vector2 paddlepos = new Vector2(mousepos, transform.position.y);
        if (paddlepos.x < paddleWidth/2)
        {
            paddlepos.x = paddleWidth / 2; 
        }else if (paddleWidth/2 + paddlepos.x > worldSize)
        {
            paddlepos.x = worldSize - paddleWidth/2;
        }
        transform.position = paddlepos;
        
    }
}
