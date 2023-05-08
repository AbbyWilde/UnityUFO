using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehavior 
{
    public float speed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        // moves componante forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
