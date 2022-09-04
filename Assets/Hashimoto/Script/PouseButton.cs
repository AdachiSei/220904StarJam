using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseButton : MonoBehaviour
{
    [SerializeField]
    Text _pauseText;


    private void Awake()
    {
        PauseManager.Instance.OnPause += OnPause;
        PauseManager.Instance.OnResume += OnResume;
        _pauseText.text = "�|�[�Y";
    }

    public void OnPause()
    {
        _pauseText.text = "�Q�[���ĊJ";
        print("�|�[�Y��");
    }

    public void OnResume()
    {
        _pauseText.text = "�|�[�Y";
        print("�|�[�Y�I��");
    }
}
