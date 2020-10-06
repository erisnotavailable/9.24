using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Player myPlayer;
    void OnTriggerStay2D(Collider2D activator)
    {
        myPlayer.onGround = true;
    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D activator)
    {
        myPlayer.onGround = false;
    }
}
