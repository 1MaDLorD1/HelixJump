using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatformSegment : MonoBehaviour
{
    private DeadScreen _deadScreen;

    private void Awake()
    {
        _deadScreen = FindObjectOfType<DeadScreen>();
    }

    public void EndGame()
    {
        _deadScreen.Pause();
    }
}
