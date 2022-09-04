using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    [Header("敵や障害物")]
    GameObject[] _enemies;

    [SerializeField]
    [Header("アイテム")]
    GameObject[] _items;

    [SerializeField]
    [Header("最短の生成時間")]
    int _minTime = 1;

    [SerializeField]
    [Header("最長の生成時間")]
    int _maxTime = 6;

    [SerializeField]
    [Header("一番低い生成位置")]
    float _minPosY = -4;

    [SerializeField]
    [Header("一番高い生成位置")]
    float _maxPosY = 4;

    float _coolTime;
    float _randomPosY;

    void Awake()
    {
        //+= Pause;
        //+= Restart;
        StartCoroutine(EnemyGenerate());
    }

    IEnumerator EnemyGenerate()
    {
        while (true)
        {
            _coolTime = Random.Range(_minTime,_maxTime);
            _randomPosY = Random.Range(_minPosY,_maxPosY);
            yield return new WaitForSeconds(_coolTime);
            Instantiate(_enemies[Random.Range(0,_enemies.Length)],
                        new Vector3(0f,_randomPosY),
                        Quaternion.identity);
        }
    }

    IEnumerator ItemGenerate()
    {
        while (true)
        {
            _coolTime = Random.Range(_minTime, _maxTime);
            _randomPosY = Random.Range(_minPosY, _maxPosY);
            yield return new WaitForSeconds(_coolTime);
            Instantiate(_items[Random.Range(0, _items.Length)],
                        new Vector3(0f, _randomPosY),
                        Quaternion.identity);
        }
    }

    void Pause()
    {
        StopAllCoroutines();
    }

    void Restart()
    {
        EnemyGenerate();
        ItemGenerate();
    }
}
