using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //自オブジェクト(Block)に当たった先のオブジェクト名が"Ball"だった場合
        if (collision.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);   //そのオブジェクト(Block)を削除する
        }
    }
}
