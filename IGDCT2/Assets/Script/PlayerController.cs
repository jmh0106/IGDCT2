using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //플레이어 이동속도
    public float playerMoveSpeed = 10;
    //플레이어 이동방향 저장 변수
    public Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        PlayerControl();
    }
    
    private void PlayerControl() //유니티 GetAxisRaw 기능을 활용한 플레이어 이동
    {
        //키보드 입력 받기
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");

        //키보드로 받은 입력 변수에 저장하고 정규화(normalized)하기
        moveDirection = new Vector3(x, y, 0).normalized;

        //현재 위치에 [이동방향 * 이동속도 * 시간] 더해서 플레이어 움직이기
        transform.position += moveDirection * playerMoveSpeed * Time.deltaTime;
    }
}
