using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ItemBase�̔h���N���X
/// </summary>
public class Item : ItemBase
{
    [SerializeField]
    [Header("Score���Z��")]
    const int SCORE = 20;

    protected override void ItemEffect()
    {
        ScoreManager.Instance.AddScore(SCORE);
    }
}
