using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public GameObject DestroyEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
        Destroy(effect, 2.5f);
        Destroy(gameObject);
    }

}
