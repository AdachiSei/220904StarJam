using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�R�A���Ǘ��������
/// </summary>
public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    /// <summary>Plus����X�R�A��</summary>
    public int Score => _score;

    /// <summary>Plus����X�R�A��</summary>
    int _score;

    public int AddScore(int score) => _score += score;//Score�����Z�������
}
