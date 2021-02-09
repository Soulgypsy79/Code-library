using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Library : MonoBehaviour
{
    public Spawn SpawnTemplate;

    private void Start()
    {


        // Clone the template game object
        Spawn ballClone = Instantiate(SpawnTemplate);

        // Move the new ball clone to the ball spawner's position
        ballClone.transform.position = transform.position;

        // Activate the new ball clone
        ballClone.gameObject.SetActive(true);

       
    }

}




