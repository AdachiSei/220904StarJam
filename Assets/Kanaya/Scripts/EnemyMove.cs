using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    [SerializeField]
    [Header("è„â∫ç∑")]
    float _move = 3;

    private void Awake()
    {
        PauseManager.Instance.OnPause += Pause;
        PauseManager.Instance.OnRestart += Restart;
    }

    private void Update()
    {
        Vector2 pos = transform.position;

        pos.y = Mathf.PingPong(Time.time, _move);

        transform.position = new Vector2(transform.position.x, pos.y);

        transform.position = pos; 
    }
    
    void Pause()
    {
        this.gameObject.SetActive(false);
    }

    void Restart()
    {
        this.gameObject.SetActive(true);
    }
}
