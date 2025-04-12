using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHookMovement : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("object Entered");
        if(collision.tag != "Player") {return;}
        Debug.Log("Player");

        StartCoroutine(transform.GetComponentInParent<FishHook>().Move());
    }
}
