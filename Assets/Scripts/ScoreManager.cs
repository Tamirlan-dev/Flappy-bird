using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int mult = 1;
    double speed = 0.1;
    int score;
    void Start()
    {
        if (instance == null){
            instance = this;
        }
    }

    // Update is called once per frame
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
        if (score != 0 && score % 3 == 0)
        {
            mult=mult*2;
        }
    }
    public float getSpeed()
    {
        
         return (float)(mult*speed);
        
    }
}
