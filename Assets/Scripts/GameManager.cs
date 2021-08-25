using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum GameState {HOME, GAME, MATCHOVER};
    public GameState _state;
    [SerializeField]
    public GameObject _ballPrefab;
    [SerializeField]
    private GameObject _playersPrefab;
    private GameObject _currentball;
    [HideInInspector]
    public GameObject _instantiatedPlayers;
    public GameObject homepanel;
    public GameObject scorePanel;
    public GameObject MatchoverPanel;
       
    public Transform[] spawnPosR;
    public Transform[] spawnPosL;
    public static bool _firstBall = true;
    
    float[] hori = {-1f, 1f};

    void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        _state = GameState.HOME;
        
    }

   
    void Update()
    {
        switch(_state)
        {   
            case GameState.HOME :
            homepanel.SetActive(true); 
            scorePanel.SetActive(false);
            MatchoverPanel.SetActive(false);
            break;

            case GameState.GAME :
            homepanel.SetActive(false);
             scorePanel.SetActive(true);
             MatchoverPanel.SetActive(false);
             if(_instantiatedPlayers == null)
             {
                 _instantiatedPlayers = Instantiate(_playersPrefab);
             }

            if(_currentball == null)
            {
                if(_firstBall)
                {
                _currentball = Instantiate(_ballPrefab);
                _firstBall = false;
                
                BallScript._launchDirHor = hori[Random.Range(0,2)];
                }
                
            if(ScoreCounter.scoredRNow)
            {
                _currentball = Instantiate(_ballPrefab);
                _currentball.transform.position =  spawnPosR[Random.Range(0,2)].position;
                BallScript._launchDirHor = -1f;
                ScoreCounter.scoredRNow = false;
            }
            else if(ScoreCounter.scoredLNow)
            {
                _currentball = Instantiate(_ballPrefab);
                _currentball.transform.position =  spawnPosL[Random.Range(0,2)].position;
                BallScript._launchDirHor = 1f;
               ScoreCounter.scoredLNow = false;
            }
            
            }             
            break;

            case GameState.MATCHOVER :
            Destroy(_currentball);
            MatchoverPanel.SetActive(true);
            break;

            
        }
       
    }
}
