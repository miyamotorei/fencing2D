using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;//プレイヤーの移動速度
    [SerializeField] private float maxY,minY; //移動範囲の制限

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
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            Vector3 playerPos = transform.position; //Vector3型のplayerPosに現在の位置情報を格納
            playerPos.y += speed * Time.deltaTime; //y座標にspeedを加算

            //追加
            //もしplayerPosのY座標がmaxY (最大y座標）より大きくなったら
            if(maxY < playerPos.y)
            {
                playerPos.y = maxY; //PlayerPosのY座標にmaxYを代入
            }
            transform.position = playerPos; //現在の位置情報に反映させる

        } else if(Input.GetAxisRaw("Vertical") < 0) //もし下矢印キーが押されたら
        {
            Vector3 playerPos = transform.position; 
            playerPos.y -= speed * Time.deltaTime;

            //追加
            if (minY > playerPos.y)
            {
                playerPos.y = minY;
            }
            transform.position = playerPos; 
        }
    }
    [SerializeField] private GameObject Lazer; //レーザープレハブを格納
    [SerializeField] private Transform attackPoint;//アタックポイントを格納
    [SerializeField] private float attackTime = 0.2f; //攻撃の間隔
    private float currentAttackTime; //攻撃の間隔を管理
    private bool canAttack; //攻撃可能状態かを指定するフラグ
 }
