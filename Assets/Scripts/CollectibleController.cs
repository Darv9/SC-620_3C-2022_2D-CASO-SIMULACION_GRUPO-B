using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    
    int healthCount = 1;

    int ammoCount = 30;

    public GameObject DestroyEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.tag.Equals("Health"))
            {
                healthCount += 1;
                GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
                Destroy(effect, 2.5f);
                Destroy(gameObject);
            }
            else
            {
                ammoCount += 1;
                GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
                Destroy(effect, 2.5f);
                Destroy(gameObject);
            }
        }
    }

    public int getAmmoCount()
    {
        return ammoCount;
    }

    public int getHealthCount()
    {
        return healthCount;
    }
}
