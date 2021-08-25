using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    private Rigidbody2D _ball;
    private float _forceValue = 15f;
    private const float PI = 3.14159f;
    
    private float angleInDegree = 60f;
    
    public static float _launchDirHor;

    private float [] _launchDirVert = {-1f, 1f};
    
    void Start()
    {
        int randIndex = Random.Range(0,2);
        float angleInRadian = angleInDegree * (2 * PI) / 360;
        _ball = GetComponent<Rigidbody2D>();
        _ball.AddForce(new Vector2(_forceValue * Mathf.Cos(angleInRadian) * _launchDirHor, _forceValue * Mathf.Sin(angleInRadian) * _launchDirVert[randIndex]), ForceMode2D.Impulse);  
    }

   
}
