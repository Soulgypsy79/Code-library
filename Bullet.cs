using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float directionx;
    public float speed;
    public float size;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);

       

    }

    public void Shoot()
    {
            Vector3 scale = new Vector3();
            scale.x = size;
            scale.y = size;
            transform.localScale = scale;

            Vector3 position = transform.localPosition;
            position.x += speed * directionx;
            transform.localPosition = position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // This switch statement compares the other game object name to each of the cases
        // within the switch. If the other game object name matches one of the cases then
        // all the statements underneath that case will be run, until the break statement.
        switch (other.gameObject.name)
        {
            case "Ball":
                directionx = -directionx;
                break;
        }
    }
}