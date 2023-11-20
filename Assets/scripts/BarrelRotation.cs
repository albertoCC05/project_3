using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRotation : MonoBehaviour
{
    private float speed = 100;

    private void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed, Space.World);
    }
}
