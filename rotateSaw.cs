using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSaw : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private void Update()
    {
        transform.Rotate(0, 0, 180 * speed * Time.deltaTime);
    }
}
