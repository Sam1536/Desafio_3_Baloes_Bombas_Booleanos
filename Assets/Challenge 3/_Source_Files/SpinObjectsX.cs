using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    public float spinSpeed;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
