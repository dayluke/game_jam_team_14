using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusTileScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            coll.gameObject.GetComponent<PlayerHealthBreatheAmmo>().health.Deduct();
        }
    }
}
