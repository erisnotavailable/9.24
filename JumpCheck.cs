using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    public Player myPlayer;
    void OnTriggerEnter2D(Collider2D activator)
    {
        myPlayer.canJump = true;
        Debug.Log("triggered");
    }

    void OnTriggerStay2D(Collider2D activator)
    {
       Destroy(this);
    }
}
