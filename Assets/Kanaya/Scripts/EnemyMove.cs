using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    [SerializeField]
    [Header("è„â∫ç∑")]
    float _move = 3;

    private void Update()
    {
        Vector2 pos = transform.position;

        pos.y = Mathf.PingPong(Time.time, _move);

        transform.position = new Vector2(transform.position.x, pos.y);

        transform.position = pos; 
    }
}
