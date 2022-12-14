using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 基底クラス
/// </summary>
public class ItemBase : MonoBehaviour
{
    int _score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")//まだInterfaceでやるか決まってない
        {
            ItemEffect();
            SoundManager.Instance.PlaySFX(SFXType.Item);
            Destroy(gameObject);
        }
    }

    protected virtual void ItemEffect() => ScoreManager.Instance.AddScore(_score);


}
