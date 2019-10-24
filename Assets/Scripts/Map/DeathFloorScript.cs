using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFloorScript : MonoBehaviour
{
    [SerializeField]
    private Vector3 spawnPosition = Vector3.zero;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player fell out of world");
            coll.gameObject.transform.position = spawnPosition;
        }
    }
}
