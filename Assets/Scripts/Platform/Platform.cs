using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _bounceForce;
    [SerializeField] private float _bounceRadius;

    public void Break()
    {
        PlatformSegment[] platformSegments = GetComponentsInChildren<PlatformSegment>();
        BadPlatformSegment[] badPlatformSegments = GetComponentsInChildren<BadPlatformSegment>();

        foreach (var segment in platformSegments)
        {
            segment.Bounce(_bounceForce, transform.position, _bounceRadius);
        }

        foreach (var segment in badPlatformSegments)
        {
            segment.Bounce(_bounceForce, transform.position, _bounceRadius);
        }
    }
}
