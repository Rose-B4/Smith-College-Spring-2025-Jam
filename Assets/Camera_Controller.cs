using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_Controller : MonoBehaviour
{
    CinemachineVirtualCamera virtualCamera;
    Player_Controller player;
    // Start is called before the first frame update
    void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        player = FindAnyObjectByType<Player_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.spriteRenderer.flipX) {
            // virtualCamera.
        }
    }
}
