using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWalls : MonoBehaviour
{
    MeshRenderer mr;

    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Shit, Blud collided!");
        // Debug.Log(collision.gameObject.name);

        // changing the colour of the wall
        mr = GetComponent<MeshRenderer>();

        if (collision.gameObject.tag == "Blud")
        {
            mr.material.color = Color.red;
        }
       
    }

    private void OnCollisionExit(Collision collision)
    {
        // Debug.Log("Blud just left!");
    }
}
