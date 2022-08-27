using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalLogic : MonoBehaviour
{
    public float _TimerSec = 30;
    private bool _Timer = false;
    private void Update()
    {
        if(_Timer == false)
        {
            StartCoroutine(DestroyTimer());
            _Timer = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerControl>()._PlayerOz += 1;
            Destroy(gameObject);
        }
    }
    IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(_TimerSec);
        Destroy(gameObject);
    }
}
