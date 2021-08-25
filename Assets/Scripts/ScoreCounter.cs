using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public static ScoreCounter counter;
    [HideInInspector]
    public static int scoreL = 0;
    [HideInInspector]
    public static int scoreR = 0;
    public Text scoreTextL;
    public Text scoreTextR;
    [HideInInspector]
    public static bool scoredRNow;
    [HideInInspector]
    public static bool scoredLNow;
    

    void Start()
    {
        scoreTextL.text = "" + scoreL;
        scoreTextR.text = "" + scoreR;
        counter = this;
        
    }
    void Update()
    {
        if(scoreL>=7)
        {
            GameManager.instance._state = GameManager.GameState.MATCHOVER;
        }
        else if(scoreR>=7)
        {
            GameManager.instance._state = GameManager.GameState.MATCHOVER;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D ball) 
    {
        if(ball.CompareTag(Tags.BALL_TAG) && gameObject.name == "WallLeft")
        {
            Destroy(ball.gameObject);
            scoreR++;
            scoreTextR.text = "" + scoreR;
            scoredRNow = true;
        }
        else if(ball.CompareTag(Tags.BALL_TAG) && gameObject.name == "WallRight")
        {
            Destroy(ball.gameObject);
            scoreL++;
            scoreTextL.text = "" + scoreL;
            scoredLNow = true;
        }    
    }
}
