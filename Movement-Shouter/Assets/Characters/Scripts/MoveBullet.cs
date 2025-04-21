using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 500f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = rb.transform.forward * speed * Time.fixedDeltaTime;
        Debug.Log("schiet");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
