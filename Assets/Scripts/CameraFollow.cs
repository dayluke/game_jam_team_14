using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    [SerializeField]
    private int yOffset = 1;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").gameObject.transform;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);
    }
}
