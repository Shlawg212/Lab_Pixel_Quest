using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SomethingAwesome : MonoBehaviour
{
    public int speed = 10;
    public string nextlevel = "Scene_2";
    private Rigidbody2D Rb;
    string variable2 = "World ";
 
   // Start is called before the first frame update
    void Start() { 
     
        Debug.Log("Hello World");
        string variable1 = "Hello ";
        Debug.Log(variable1 + variable2);
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        Rb.velocity = new Vector2(xInput * 10, Rb.velocity.y);
        /*
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 1f, 0);
        }
       */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {

            case "Death":
                {
                    string thisLevel = "Scene_1";
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }

        }
    }



    public class ColorChanger : MonoBehaviour { }

    // Variable to store the player's renderer component
    private Renderer playerRenderer;

    void start()
    {
        // Get the Renderer component attached to the GameObject
        playerRenderer = GetComponent<Renderer>();

        // Optional: Set an initial color in the Start method
        // playerRenderer.material.color = Color.white;
    }

    void update()
    {
        // Check if the 'R' key is pressed down
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Change the player's color to red
            playerRenderer.material.color = Color.red;
        }

        // Check if the 'G' key is pressed down
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Change the player's color to green
            playerRenderer.material.color = Color.green;
        }

        // Check if the 'B' key is pressed down
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Change the player's color to blue
            playerRenderer.material.color = Color.blue;
        }
    }
}




 // Update is called once per frame
    




