using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    public float _SpawnCoolDown = 3f;

    [Header("Debuf")]
    private bool _HasSpawn = true;
    void Update()
    {
        if(_HasSpawn == true)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            _HasSpawn = false;
            StartCoroutine(EnemySpawner());
        }
    }
    IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(_SpawnCoolDown);
        _HasSpawn = true;
    }
}
