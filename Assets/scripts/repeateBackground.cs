using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeateBackground : MonoBehaviour
{
    private float RepeatingWidth;
    private Vector3 startPosition;

    private void Start()
    {
        RepeatingWidth = GetComponent<BoxCollider>().size.x / 2;
        startPosition = new Vector3 (50.75f, 9.33f, 5f);
    }

    private void Update()
    {
        if (transform.position.x < startPosition.x - RepeatingWidth)
        {
            transform.position = startPosition;
        }
    }
}
