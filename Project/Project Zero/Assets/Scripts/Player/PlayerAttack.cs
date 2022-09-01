using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private int _Mana;
    public GameObject player;
    public GameObject bullet;

    void Start()
    {
   
    }

    
    void FixedUpdate()
    {
        _Mana = player.GetComponent<PlayerControl>()._PlayerMana;
        PlayerAt();
    }
    private void Update()
    {
        Bullet();
    }
    private void PlayerAt()
    {
        //Отвечает за поворот объекта в сторону мыши
        if(UpgradeLogic._Pause == false)
        {
            var dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;
            transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        }
        
    }
    private void Bullet()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) & _Mana > 0 & UpgradeLogic._Pause == false)
        {
            Instantiate(bullet, gameObject.transform.position,gameObject.transform.rotation);
            player.GetComponent<PlayerControl>()._PlayerMana -= 2;
        }
    }
}
