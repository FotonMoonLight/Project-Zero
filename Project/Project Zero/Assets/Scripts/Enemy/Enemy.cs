using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int _HpEnemy = 10;
    public float _EnemySpeed;

    public GameObject player;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Vector3 velocity = (player.transform.position - transform.position);
        transform.position = transform.position + _EnemySpeed * velocity.normalized * Time.fixedDeltaTime;
        if(_HpEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }
}
