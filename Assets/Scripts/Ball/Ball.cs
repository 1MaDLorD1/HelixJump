using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlatformSegment platformSegment))
        {
            platformSegment.GetComponentInParent<Platform>().Break();
        }
        else if(other.TryGetComponent(out BadPlatformSegment badPlatformSegment))
        {
            badPlatformSegment.Dead();
        }
        else if (other.TryGetComponent(out FinishPlatformSegment finishPlatformSegment))
        {
            finishPlatformSegment.GetComponentInParent<FinishPlatform>().Finish();
        }
    }
}
