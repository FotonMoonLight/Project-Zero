using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallZone : MonoBehaviour
{
    public int _WallNum = 0;
    public int _Speed = 2;

    public GameObject player;

    public bool _TouchMeTralala = false;
    
    void Update()
    {
        if(_TouchMeTralala == true & _WallNum == 1)
        {
            player.transform.Translate(Vector2.left * _Speed * Time.deltaTime);
            _TouchMeTralala = false;
        }
        if (_TouchMeTralala == true & _WallNum == 2)
        {
            player.transform.Translate(Vector2.right * _Speed * Time.deltaTime);
            _TouchMeTralala = false;
        }
        if (_TouchMeTralala == true & _WallNum == 3)
        {
            player.transform.Translate(Vector2.down * _Speed * Time.deltaTime);
            _TouchMeTralala = false;
        }
        if (_TouchMeTralala == true & _WallNum == 4)
        {
            player.transform.Translate(Vector2.up * _Speed * Time.deltaTime);
            _TouchMeTralala = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _TouchMeTralala = true;
        }
    }
}
