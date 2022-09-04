using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ItemBase�̔h���N���X
/// </summary>
public class Item : ItemBase
{
    public int Score => _score;

    [SerializeField]
    [Header("Score���Z��")]
    int _score;

    protected override void ItemEffect()
    {
        ScoreManager.Instance.AddScore(Score);
    }
}
