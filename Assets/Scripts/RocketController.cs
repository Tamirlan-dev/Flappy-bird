using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    Rigidbody2D rb;
    bool alive = true;
    float rotationX, rotationY;
    int heals = 4;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if ( alive == true)
        {
            rotationX = CrossPlatfromInputManager.GetAxis("Horizontal");
        
            rb.velocity = new Vector2(0, 5f);
        }
    }
    void OnGUI()
    {
        if (Event.current.isKey && Event.current.type == EventType.KeyDown)
        {
            Debug.Log(Event.current.keyCode);
        }
    }
}
