using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    [Header("ìGÇ‚è·äQï®")]
    GameObject[] _enemies;

    [SerializeField]
    [Header("ÉAÉCÉeÉÄ")]
    GameObject[] _items;

    [SerializeField]
    [Header("ç≈íZÇÃê∂ê¨éûä‘")]
    int _minTime = 1;

    [SerializeField]
    [Header("ç≈í∑ÇÃê∂ê¨éûä‘")]
    int _maxTime = 6;

    [SerializeField]
    [Header("àÍî‘í·Ç¢ê∂ê¨à íu")]
    float _minPosY = -4;

    [SerializeField]
    [Header("àÍî‘çÇÇ¢ê∂ê¨à íu")]
    float _maxPosY = 4;

    float _coolTime;
    float _randomPosY;

    void Awake()
    {
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
