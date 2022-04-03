using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //플레이어 변수
    private GameObject _player;

    private void Start()
    {
        //만약 플레이어가 없다면, "Player" 태그를 가진 오브젝트를 가져와서 변수에 넣어주기
        if (_player == null)
            _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        TilePosUpdate();
    }

    private void TilePosUpdate()
    {
        //플레이어 좌표 가져오기 [플레이어 위치 4가 움직일때마다 반응하도록 4로 나누기]
        var position = _player.transform.position;
        var x = position.x / 4;
        var y = position.y / 4;

        //플레이어 위치에 맞게 타일 움직이기 [플레이어 위치 4가 움직일때마다 타일도 4씩 움직이도록 4 곱해주기]
        this.transform.position = new Vector3((int) x * 4, (int) y * 4, 0);
    }
}
