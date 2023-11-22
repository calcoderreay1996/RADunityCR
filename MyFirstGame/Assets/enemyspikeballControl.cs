using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspikeballControl : MonoBehaviour
{
    private Vector3 dir = Vector3.up;
    private object enemyspikeKill;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += (new Vector3(0, 1, 2)) * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
            transform.position += (new Vector3(0, 1, 2)) * Time.deltaTime;

        transform.Translate(dir * Time.deltaTime);

        if (transform.position.y <= 0)
        {
            dir = Vector3.up;
        }
        else if (transform.position.y >= 4)
        {
            dir = Vector3.down;
        }
        {
            transform.position += *enemyspikeKill ,
        }
        }

    }
    

