using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Obstacle : MonoBehaviour
{
    void Start() {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag != "Player") { return; }

        Debug.Log("Player entered trap");

        OnObstacleEntered(collision);
    }

    public virtual void OnObstacleEntered(Collider2D other) {
        Debug.LogError("Method not overloaded in "+transform.name);
    }
}
