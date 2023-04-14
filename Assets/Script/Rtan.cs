using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.04f;
    float toward = 1.0f; //좌우반전의 방향 (x 좌표?)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1; //좌우반전
            direction *= -1; //방향반전
        }
        if (transform.position.x > 2.8f)
        {
            direction = -0.05f;
            toward = -1.0f;
        }
        if (transform.position.x < -2.8f)
        {
            direction = 0.05f;
            toward = 1.0f;
        }
        transform.localScale = new Vector3(toward, 1, 1);
        transform.position += new Vector3(direction, 0, 0);
    }
}
