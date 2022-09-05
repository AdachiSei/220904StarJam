using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int _junp;
    [SerializeField] int _overline;
    [SerializeField] int _mutekiTime;
    [SerializeField] int _scoreCount;

    [SerializeField] bool _muteki;

    Rigidbody2D _rb2;
    Vector3 _rb;

    float _gravityScale;
    private Vector2 pos;

    [SerializeField]
    [Header("GameOverImage")]
    Image _image;


    bool _isPlaying = true;
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
        PauseManager.Instance.OnPause += Pause;
        PauseManager.Instance.OnRestart += Restart;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isPlaying)
        {
            _rb2.velocity = new Vector2(0, _junp);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(_muteki == false)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Debug.Log("敵に当たった。");

                SoundManager.Instance.PlaySFX(SFXType.Enemy);

                ScoreManager.Instance.AddScore(_scoreCount);

                this.gameObject.SetActive(false);

                _image.gameObject.SetActive(true);

                UIManager.Instance.ScoreText.text = "スコア:" + ScoreManager.Instance.Score.ToString();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_muteki == false)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Debug.Log("敵に当たった。");

                SoundManager.Instance.PlaySFX(SFXType.Enemy);

                ScoreManager.Instance.AddScore(_scoreCount);

                this.gameObject.SetActive(false);

                _image.gameObject.SetActive(true);

                UIManager.Instance.ScoreText.text = "スコア:" + ScoreManager.Instance.Score.ToString();
            }
        }

        if (collision.gameObject.tag == "MutekiItem")
        {
            Debug.Log("無敵");

            _muteki = true;

            SoundManager.Instance.PlaySFX(SFXType.Item);
            SoundManager.Instance.PlayBGM(BGMType.Invincible);

            Invoke("MuteliOn", _mutekiTime);
        }

        Destroy(collision.gameObject);
    }

    private void MuteliOn()
    {
        _muteki = false;

        Debug.Log("タイムアップ");
        SoundManager.Instance.PlayBGM(BGMType.Game);
    }

    void Pause()
    {
        _rb = _rb2.velocity;//移動方向を保存
        _gravityScale = _rb2.gravityScale;
        _rb2.gravityScale = 0f;
        _rb2.velocity = Vector2.zero;//そこで止めてる
        _isPlaying = false;

    }

    void Restart()
    {
        _rb2.velocity = _rb;
        _rb2.gravityScale = _gravityScale;
        _isPlaying = true;
    }
}
