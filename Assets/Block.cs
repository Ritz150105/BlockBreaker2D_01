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
        //���I�u�W�F�N�g(Block)�ɓ���������̃I�u�W�F�N�g����"Ball"�������ꍇ
        if (collision.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);   //���̃I�u�W�F�N�g(Block)���폜����
        }
    }
}
