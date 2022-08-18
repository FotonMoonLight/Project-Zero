using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    public int damage;
    public int damageTime;
    public int _LifeTime = 10;

    private int _LifeCorutin = 1;

    public float speed;

    public GameObject point;
    public GameObject enemy;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        Vector2 vel = new Vector2(point.transform.position.x - gameObject.transform.position.x, point.transform.position.y - gameObject.transform.position.y);
        rb.AddForce(vel.normalized * speed * Time.fixedDeltaTime,ForceMode2D.Impulse);

        if(_LifeCorutin == 1)
        {
            _LifeCorutin = 0;
            StartCoroutine(LifeTime());
        }

        if(damageTime > 0)
        {
            enemy.GetComponent<Enemy>()._HpEnemy -= damage;
            damageTime = 0;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemy = collision.gameObject;
            damageTime += 1;
        }
    }

    IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(_LifeTime);
        Destroy(gameObject);
    }
}
