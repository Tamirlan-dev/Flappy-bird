using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    bool alive = true;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive == true)
        {
            rb.velocity = new Vector2(0, 5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        alive = false;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Coins"))
        {
            Destroy(col.gameObject);

        }
    }
}
