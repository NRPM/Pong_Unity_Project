using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    
    public void GoToGameplay()
    {
       
        GameManager.instance._state = GameManager.GameState.GAME;
    }
    public void GoToReplay()
    {
        ScoreCounter.scoreL = 0;
        ScoreCounter.scoreR = 0;
        ScoreCounter.counter.scoreTextL.text = "" + ScoreCounter.scoreL;
        ScoreCounter.counter.scoreTextR.text = "" + ScoreCounter.scoreR;
        GameManager._firstBall = true;
        GameManager.instance._state = GameManager.GameState.GAME;
    }
    public void GoToHome()
    {
        ScoreCounter.scoreL = 0;
        ScoreCounter.scoreR = 0;
        ScoreCounter.counter.scoreTextL.text = "" + ScoreCounter.scoreL;
        ScoreCounter.counter.scoreTextR.text = "" + ScoreCounter.scoreR;
        GameManager._firstBall = true;
        Destroy(GameManager.instance._instantiatedPlayers);
        GameManager.instance._state = GameManager.GameState.HOME;
    }
    
        
}
