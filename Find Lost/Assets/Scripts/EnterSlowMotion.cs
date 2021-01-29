using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSlowMotion : MonoBehaviour
{
    [SerializeField] float SlowMotionIntensity = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = SlowMotionIntensity;
    }
}
