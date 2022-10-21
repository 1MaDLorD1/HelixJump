using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : Platform
{
    public void Finish()
    {
        FinishPlatformSegment finishPlatformSegment = GetComponentInChildren<FinishPlatformSegment>();
        finishPlatformSegment.EndGame();
    }
}
