using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int _PlayerHP = 20;
    public float _MovementSpeed;
    public Sprite[] sprites;
    public bool _IsImposible = false;
    private bool _HasControll = true;

    public GameObject stick;
    public GameObject buttonOne;
    public GameObject buttonTwo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_IsImposible == false)
        {
            PlayerHpControll();
        } 
        
        
        
            PlayerController();
        
        
            PlayerMove();
        
       
        PlayerSpriteRenderer();
    }
    private void PlayerController()
    {
        if(_HasControll == true)
        {
            float Hor = Input.GetAxis("Horizontal");
            float Ver = Input.GetAxis("Vertical");
            Vector3 velocity = new Vector3(Hor, Ver, 0);
            transform.position = transform.position + _MovementSpeed * velocity.normalized * Time.fixedDeltaTime;
        }
          
    }
    private void PlayerMove()
    {
        if(transform.position.x >= 115)
        {
            transform.Translate(Vector2.left * _MovementSpeed * Time.deltaTime);
            _HasControll = false;
        }
        else
        {
            _HasControll = true;
        }
        if (transform.position.x <= 41.84f)
        {
            transform.Translate(Vector2.right * _MovementSpeed * Time.deltaTime);
            _HasControll = false;
        }
        else
        {
            _HasControll = true;
        }
        if (transform.position.y >= 51.2f)
        {
            transform.Translate(Vector2.down * _MovementSpeed * Time.deltaTime);
            _HasControll = false;
        }
        else
        {
            _HasControll = true;
        }
        if (transform.position.y <= -26.27f)
        {
            transform.Translate(Vector2.up * _MovementSpeed * Time.deltaTime);
            _HasControll = false;
        }
        else
        {
            _HasControll = true;
        }

    }
    private void PlayerHpControll()
    {
        if (_PlayerHP <= 0)
        {
            Destroy(gameObject);
            buttonOne.SetActive(true);
            buttonTwo.SetActive(true);

        }
    }
    private void PlayerSpriteRenderer()
    {
        
            if(Input.GetKey(KeyCode.W))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                stick.GetComponent<SpriteRenderer>().sortingOrder = 4;
            }
        
        
        
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
                stick.GetComponent<SpriteRenderer>().sortingOrder = 6;
            }
        
        
          
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
                stick.GetComponent<SpriteRenderer>().sortingOrder = 4;
            }
        
        
        
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
                stick.GetComponent<SpriteRenderer>().sortingOrder = 6;
            }
        
        
        
    }
   
}
