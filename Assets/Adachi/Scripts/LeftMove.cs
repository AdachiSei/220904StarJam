using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove : MonoBehaviour
{
    [SerializeField]
    [Header("スピード")]
    float _speed = -0.03f;

    bool _isPause = true;

    void Awake()
    {
        PauseManager.Instance.OnPause += Pause;
        PauseManager.Instance.OnRestart += Restart;
    }

    void Update()
    {
        if (_isPause)
        {
            var pos = gameObject.transform.position;
            pos.x += _speed;
            gameObject.transform.position = pos;
        }
    }

    void Pause()
    {
        _isPause = false;
    }

    void Restart()
    {
        _isPause = true;
    }
}
