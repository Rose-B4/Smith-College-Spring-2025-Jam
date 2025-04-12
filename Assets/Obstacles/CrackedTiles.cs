using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedTiles : Obstacle
{
    public override void OnObstacleEntered(Collider2D other)
    {
        Destroy(gameObject);
    }
}
