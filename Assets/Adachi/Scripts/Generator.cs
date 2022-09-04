using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    [Header("�G���Q��")]
    GameObject[] _enemies;

    [SerializeField]
    [Header("�A�C�e��")]
    GameObject[] _items;

    [SerializeField]
    [Header("�ŒZ�̐�������")]
    int _minTime = 1;

    [SerializeField]
    [Header("�Œ��̐�������")]
    int _maxTime = 6;

    [SerializeField]
    [Header("��ԒႢ�����ʒu")]
    float _minPosY = -4;

    [SerializeField]
    [Header("��ԍ��������ʒu")]
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
