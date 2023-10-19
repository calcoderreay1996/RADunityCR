using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
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
    }
}
