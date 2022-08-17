using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float _MovementSpeed;
    public Sprite[] sprites;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerController();
        PlayerSpriteRenderer();
    }
    private void PlayerController()
    {
        float Hor = Input.GetAxis("Horizontal");
        float Ver = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(Hor, Ver, 0);
        transform.position = transform.position + _MovementSpeed * velocity.normalized * Time.fixedDeltaTime;
    }
    private void PlayerSpriteRenderer()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
        }
    }
}