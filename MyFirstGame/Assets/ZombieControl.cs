using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    private Vector3 dir = Vector3.left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Move zombie left and right automatically
        transform.Translate(dir * Time.deltaTime);

        if (transform.position.x <= -4)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }
    }
}
