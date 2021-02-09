using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour

{
    public float size = 1.0f;
    float speed = 0.2f;
    float directionX = -1.0f;
    

    void FixedUpdate()
    {
        Vector3 scale = new Vector3();
        scale.x = size;
        scale.y = size;
        transform.localScale = scale;

        Vector3 position = transform.localPosition;
        position.x += speed * directionX;
        transform.localPosition = position;
    }


}