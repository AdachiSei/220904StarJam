using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    public Text ScoreText => _scoreText;

    [SerializeField]
    Text _scoreText;


}
