using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    public GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        PlayerAt();
    }
    private void Update()
    {
        Bullet();
    }
    private void PlayerAt()
    {
        //Отвечает за поворот объекта в сторону мыши
        var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
    }
    private void Bullet()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(bullet, gameObject.transform.position,gameObject.transform.rotation);
        }
    }
}
