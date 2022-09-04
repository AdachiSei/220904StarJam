using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
    public event Action OnPause;
    public event Action OnResume;

    bool _isPause;

    public void Pause()
    {
        switch (_isPause)
        {
            case false:
                OnPause.Invoke();
                _isPause = true;
                break;
            case true:
                OnResume.Invoke();
                _isPause = false;
                break;
        }
    }
}
