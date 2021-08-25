using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private KeyCode playerUp;
    [SerializeField]
    private KeyCode playerDown;
    private Transform player;
    private float movementSpeed = 15f;    
    
    void PlayerMove()
    {
        if(Input.GetKey(playerUp))
        {
            player.position += new Vector3(0, movementSpeed * Time.deltaTime,0);
            if(player.position.y >= 5.25f)
            {
                player.position = new Vector3(player.position.x, 5.25f, player.position.z);
            }
        }

        if(Input.GetKey(playerDown))
        {
            player.position -= new Vector3(0, movementSpeed * Time.deltaTime,0);
            
            if(player.position.y <= -5.25f)
            {
                player.position = new Vector3(player.position.x, -5.25f, player.position.z);
            }
        }
    }
    
    void Awake()
    {
        player = GetComponent<Transform>();
    }
        
    void Update()
    {
        PlayerMove();
    }
}
