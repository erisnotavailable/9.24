using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D activator)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
