using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BadPlatformSegment : MonoBehaviour
{
    private DeadScreen _deadScreen;

    private void Awake()
    {
        _deadScreen = FindObjectOfType<DeadScreen>();
    }

    public void Dead()
    {
        _deadScreen.Pause();
    }

    public void Bounce(float force, Vector3 centre, float radius)
    {
        if (TryGetComponent(out Rigidbody rigidbody))
        {
            rigidbody.isKinematic = false;
            rigidbody.AddExplosionForce(force, centre, radius);
        }
    }
}
