using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHitSounds : MonoBehaviour
{
    private AudioSource _audiosource;
    void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }
   private void OnCollisionEnter2D(Collision2D collision)
   {
        _audiosource.Play();    
   }
}
