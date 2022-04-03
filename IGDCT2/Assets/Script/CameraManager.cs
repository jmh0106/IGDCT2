using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private GameObject _player;
    
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        CameraPosUpdate();
    }

    private static Vector3 GetPlayerInput()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        
        return new Vector3(x, y, 0).normalized * 3;
    }
    
    private void CameraPosUpdate()
    {
        var playerInput = GetPlayerInput();
        var targetPos = _player.transform.position + playerInput + new Vector3(0, 0, -10);
        transform.position = Vector3.Lerp(this.transform.position, targetPos, Time.deltaTime * 2);
    }
}
