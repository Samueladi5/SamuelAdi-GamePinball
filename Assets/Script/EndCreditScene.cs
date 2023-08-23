using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCreditScene : MonoBehaviour
{
    public float scrollSpeed = 10f; // Adjust the scrolling speed as needed
    public RectTransform creditsPanel;

    private void Update()
    {
        // Move the credits panel upwards to simulate scrolling
        creditsPanel.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
    }
}

