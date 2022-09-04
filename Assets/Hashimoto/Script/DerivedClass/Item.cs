using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ItemBase‚Ì”h¶ƒNƒ‰ƒX
/// </summary>
public class Item : ItemBase
{
    public int Score => _score;

    [SerializeField]
    [Header("Score‰ÁZ—Ê")]
    int _score;

    protected override void ItemEffect()
    {
        ScoreManager.Instance.AddScore(Score);
    }
}
