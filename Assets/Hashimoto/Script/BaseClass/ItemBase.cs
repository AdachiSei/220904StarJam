using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���N���X
/// </summary>
public class ItemBase : MonoBehaviour
{
    int _score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")//�܂�Interface�ł�邩���܂��ĂȂ�
        {
            ItemEffect();
            SoundManager.Instance.PlaySFX(SFXType.Item);
            Destroy(gameObject);
        }
    }

    protected virtual void ItemEffect() => ScoreManager.Instance.AddScore(_score);


}
