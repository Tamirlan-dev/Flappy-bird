using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab_coin;
    public GameObject prefab_col1;
    public GameObject prefab_col2;

    int timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        timer += 1;
        if (timer >= 600)
        {
            int num = Random.Range(-2, 2);
            GameObject coin_copy = Instantiate(prefab_coin, new Vector2(prefab_coin.transform.position.x, prefab_coin.transform.position.y + num), prefab_coin.transform.rotation);
            GameObject col1_copy = Instantiate(prefab_col1, new Vector2(prefab_col1.transform.position.x, prefab_col1.transform.position.y + num), prefab_col1.transform.rotation);
            GameObject col2_copy = Instantiate(prefab_col2, new Vector2(prefab_col2.transform.position.x, prefab_col2.transform.position.y + num), prefab_col2.transform.rotation);
            timer = 0;
            Destroy(coin_copy, 12);
            Destroy(col1_copy, 12);
            Destroy(col2_copy, 12);
        }

    }
}
