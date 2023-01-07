using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFall : MonoBehaviour
{
    // Start is called before the first frame update
    int coinValue = 1;
  
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        print(ScoreManager.instance.getSpeed());
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x, transform.position.y - 0.2f), ScoreManager.instance.getSpeed());



     
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            ScoreManager.instance.ChangeScore(coinValue);
            
        }
       
    }
}
