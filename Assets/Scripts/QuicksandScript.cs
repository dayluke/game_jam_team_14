using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuicksandScript : MonoBehaviour
{
    [SerializeField]
    private float sinkSpeed = 1f;

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            coll.gameObject.GetComponent<PlayerMovement>().SlowFall();
        }
    }
}
