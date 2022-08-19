using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour
{
    public int _SpawnControll = 0;

    public GameObject mapTile;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            if(_SpawnControll == 1)
            {
                Vector3 spawner = new Vector3(transform.parent.position.x + 58, transform.parent.position.y, transform.parent.position.z);
                Instantiate(mapTile, spawner, transform.rotation);
            }
            if (_SpawnControll == 2)
            {
                Vector3 spawner = new Vector3(transform.parent.position.x - 58, transform.parent.position.y, transform.parent.position.z);
                Instantiate(mapTile, spawner, transform.rotation);
            }
            if (_SpawnControll == 3)
            {
                Vector3 spawner = new Vector3(transform.parent.position.x, transform.parent.position.y + 57, transform.parent.position.z);
                Instantiate(mapTile, spawner, transform.rotation);
            }
            if (_SpawnControll == 4)
            {
                Vector3 spawner = new Vector3(transform.parent.position.x, transform.parent.position.y - 57, transform.parent.position.z);
                Instantiate(mapTile, spawner, transform.rotation);
            }



            
        }
    }
}
