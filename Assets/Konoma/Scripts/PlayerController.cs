using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int _junp;
    [SerializeField] int _overline;
    [SerializeField] int _mutekiTime;
    [SerializeField] int _scoreCount;

    [SerializeField] bool _muteki;

    Rigidbody2D _rb2;

    private Vector2 pos;

    void Awake()
    {
        
        if( TryGetComponent(out _rb2)) 
        {
            Debug.Log("Rigidbody2Dを参照した。");
        }
        else
        {
            _rb2 = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb2.velocity = new Vector2(0, _junp);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_muteki == false)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Debug.Log("敵に当たった。");

                SoundManager.Instance.PlaySFX(SFXType.Enemy);

                ScoreManager.Instance.AddScore(_scoreCount);

                this.gameObject.SetActive(false);
            }
        }

        if (collision.gameObject.tag == "MutekiItem")
        {
            Debug.Log("無敵");

            _muteki = true;

            SoundManager.Instance.PlaySFX(SFXType.Item);

            Invoke("MuteliOn", _mutekiTime);
        }
    }

    private void MuteliOn()
    {
        _muteki = false;

        Debug.Log("タイムアップ");
    }

}
