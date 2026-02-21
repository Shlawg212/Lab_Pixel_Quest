using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomethingAwesome : MonoBehaviour
{
    string variable2 = "World ";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string variable1 = "Hello ";
        Debug.Log(variable1 + variable2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
