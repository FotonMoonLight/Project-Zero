using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int _HpEnemy = 10;
    public int _Damage;

    public bool _HasAttack = false;
    public bool _ReloadHelper = true;

    public float _EnemySpeed;

    public GameObject player;
    public GameObject crystal;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if(UpgradeLogic._Pause == false)
        {
            player = GameObject.Find("Player");
            Vector3 velocity = (player.transform.position - transform.position);
            transform.position = transform.position + _EnemySpeed * velocity.normalized * Time.fixedDeltaTime;
            if (_HpEnemy <= 0)
            {
                Instantiate(crystal, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            if (_HasAttack == true)
            {
                StartCoroutine(Reload());
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(_ReloadHelper == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                player.GetComponent<PlayerControl>()._PlayerHP -= _Damage;
                player = collision.gameObject;
                _HasAttack = true;
                _ReloadHelper = false;
            }
        }
        
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(0.2f);
        _ReloadHelper = true;
    }
}
