using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCloner : MonoBehaviour
{
    public GameObject prefab_coin1;
    int timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
        if (timer >= 180)
        {
            int num = Random.Range(-13, 13);
            GameObject coin_copy = Instantiate(prefab_coin1, new Vector2(prefab_coin1.transform.position.x+num, prefab_coin1.transform.position.y ), prefab_coin1.transform.rotation);
            timer = 0;
           
        }

    }
}
