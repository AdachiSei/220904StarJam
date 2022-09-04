using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove : MonoBehaviour
{
    [SerializeField]
    [Header("スピード")]
    float _speed = -0.03f;

    void Update()
    {
        var pos = gameObject.transform.position;
        pos.x += _speed;
        gameObject.transform.position = pos;
    }
}
