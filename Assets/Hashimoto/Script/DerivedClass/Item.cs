using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ItemBase‚Ì”h¶ƒNƒ‰ƒX
/// </summary>
public class Item : ItemBase
{
    [SerializeField]
    [Header("Score‰ÁZ—Ê")]
    const int SCORE = 20;

    protected override void ItemEffect()
    {
        ScoreManager.Instance.AddScore(SCORE);
    }
}
