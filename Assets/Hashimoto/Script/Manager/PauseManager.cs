using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
    public event Action OnPause;
    public event Action OnRestart;

    bool _isPause;

    public Image _pausePanel;

    public void Pause()
    {
        switch (_isPause)
        {
            case false:
                OnPause.Invoke();
                _isPause = true;
                _pausePanel.gameObject.SetActive(true);
                break;
            case true:
                OnRestart.Invoke();
                _isPause = false;
                _pausePanel.gameObject.SetActive(false);
                break;
        }
    }
}
