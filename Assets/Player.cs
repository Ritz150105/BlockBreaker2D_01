using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;  //playerの力(ﾁｶﾗ)の設定値

        //左カーソルが押されたら
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            force = new Vector2(playerSpeed * -1, 0); //
        }
        //右カーソルが押されたら
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(playerSpeed, 0); //
        }
        //慣性の法則  設定した力分移動させる
        myRigidbody.MovePosition(myRigidbody.position + force * Time.fixedDeltaTime);
    }
}
