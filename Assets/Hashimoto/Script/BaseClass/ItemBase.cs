using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Šî’êƒNƒ‰ƒX
/// </summary>
public class ItemBase : MonoBehaviour
{
    int _score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")//‚Ü‚¾Interface‚Å‚â‚é‚©Œˆ‚Ü‚Á‚Ä‚È‚¢
        {
            ItemEffect();
            SoundManager.Instance.PlaySFX(SFXType.Item);
            Destroy(gameObject);
        }
    }

    protected virtual void ItemEffect() => ScoreManager.Instance.AddScore(_score);


}
