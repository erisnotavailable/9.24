using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlimitedJumpCheck : MonoBehaviour
{
    public Player myPlayer;
    void OnTriggerEnter2D(Collider2D activator)
    {
        myPlayer.canUnlimitedJump = true;
        Debug.Log("cando");
    }
       
}
