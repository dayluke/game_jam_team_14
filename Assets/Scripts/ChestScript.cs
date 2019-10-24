using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            if (coll.gameObject.GetComponent<PlayerMovement>().playerHasKey)
            {
                Debug.Log("You win!");
            }
        }
    }
}
