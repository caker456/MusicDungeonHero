using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    [Header("플레이어 이동관련")]
    
    [SerializeField] Vector2 moveDir;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        moveDir.x = Input.GetAxisRaw("Horizontal") * speed;
        moveDir.y =Input.GetAxisRaw("Vertical") * speed;
        rigid.velocity= moveDir;
    }
}
