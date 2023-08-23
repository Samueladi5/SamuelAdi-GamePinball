using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRamp : MonoBehaviour
{
    public float score;

    public Collider bola;
    public ScoreManager scoreManager;

    public void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            scoreManager.AddScore(score);
        }
    }
}
