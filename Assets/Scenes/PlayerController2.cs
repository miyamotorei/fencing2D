using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private float speed;//プレイヤーの移動速度
    [SerializeField] private float maxX,minX; //移動範囲の制限

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); //プレイヤーを動かすメソットを呼び出す
    }

    void MovePlayer()
    {
        //もし上矢印キーが押されたら
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Vector3 playerPos = transform.position; //Vector3型のplayerPosに現在の位置情報を格納
            playerPos.x += speed * Time.deltaTime; //y座標にspeedを加算

            //追加
            //もしplayerPosのx座標がmaxX (最大x座標）より大きくなったら
            if(maxX < playerPos.x)
            {
                playerPos.x = maxX; //PlayerPosのX座標にmaxXを代入
            }
            transform.position = playerPos; //現在の位置情報に反映させる

        } else if(Input.GetAxisRaw("Horizontal") < 0) 
        {
            Vector3 playerPos = transform.position; 
            playerPos.x -= speed * Time.deltaTime;

            //追加
            if (minX > playerPos.x)
            {
                playerPos.x = minX;
            }
            transform.position = playerPos; 
        }
    }
}

