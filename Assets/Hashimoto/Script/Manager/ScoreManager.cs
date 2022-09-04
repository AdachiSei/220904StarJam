using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スコアを管理するもの
/// </summary>
public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    /// <summary>Plusするスコア数</summary>
    public int Score => _score;

    /// <summary>Plusするスコア数</summary>
    int _score;

    public int AddScore(int score) => _score += score;//Scoreを加算するもの
}
