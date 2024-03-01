using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropElements : MonoBehaviour
{
    [SerializeField] private float timer = 3f;
    MeshRenderer mr;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();

        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer)
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
