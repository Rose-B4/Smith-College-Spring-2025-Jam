using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHook : Obstacle
{
    [SerializeField] BoxCollider2D hookTrigger;
    [SerializeField][Range(0,0.5f)] float moveSpeed;

    public override void OnObstacleEntered(Collider2D other)
    {
        other.GetComponent<Player_Controller>().Die();
    }

    public IEnumerator Move() {
        while(true) {
            transform.Translate(Vector2.up * moveSpeed);
            yield return new WaitForFixedUpdate();
        }
    }
}
