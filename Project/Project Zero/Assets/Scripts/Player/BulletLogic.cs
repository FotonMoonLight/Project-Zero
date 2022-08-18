using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    public int damage;
    public int damageTime;
    public float speed;
    public GameObject point;
    public GameObject enemy;
    Rigidbody2D rb;
    PlayerAttack pl;
    void Start()
    {
        pl = GetComponent<PlayerAttack>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        Vector2 vel = new Vector2(point.transform.position.x - gameObject.transform.position.x, point.transform.position.y - gameObject.transform.position.y);
        rb.AddForce(vel.normalized * speed * Time.fixedDeltaTime,ForceMode2D.Impulse);
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
}
