using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    [SerializeField] int bludScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            bludScore += 1;
            Debug.Log(bludScore);

            collision.gameObject.tag = "Untagged";
        }
    }
}
