using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseButton : MonoBehaviour
{
    [SerializeField]
    [Header("ポーズ")]
    Text _pauseText;


    private void Awake()
    {
        PauseManager.Instance.OnPause += OnPause;
        PauseManager.Instance.OnRestart += OnResume;
        _pauseText.text = "ポーズ";
    }

    public void OnPause()
    {
        _pauseText.text = "ゲーム再開";
        print("ポーズ中");
    }

    public void OnResume()
    {
        _pauseText.text = "ポーズ";
        print("ポーズ終了");
    }
}
