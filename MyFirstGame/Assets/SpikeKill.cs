using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeKill : MonoBehaviour

{
    float SpikeKill = 10f;

    public spikeKill(float spikeKill)
    {
        SpikeKill = spikeKill;
    }

    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
            transform.position += (new Vector3(0, 1, 2)) * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
            transform.position += (new Vector3(0, 1, 2)) * Time.deltaTime;

        transform.Translate(dir * Time.deltaTime);

        if (transform.position.y <= 0)
        {
            dir = Vector3.up;
        }
        else if (transform.position.y >= 3)
        {
            dir = Vector3.down;
        }
        
    }
}
