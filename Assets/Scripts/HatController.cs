using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatController : MonoBehaviour
{
    Rigidbody2D rb;
    public Camera cam;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (cam == null)
        {
            cam = Camera.main;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        var targetPosition = new Vector2(rawPosition.x,0);
        GetComponent<Rigidbody2D>().MovePosition(targetPosition);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Coins"))
        {
            Destroy(col.gameObject);

        }
    }
}
