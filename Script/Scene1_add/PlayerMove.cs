using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    SpriteRenderer playerSpriteRend;
    [Header("플레이어 이동관련")]
    [SerializeField] Vector2 moveDir;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        playerSpriteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    /// <summary>
    /// 플레이어 이동을 담당하는 함수
    /// </summary>
    void Move()
    {
        if (moveDir.x>0)
        {
            playerSpriteRend.flipX = true;
        }
        else
        {
            playerSpriteRend.flipX = false;
        }
        anim.SetFloat("Horizontal", moveDir.x);
        anim.SetFloat("Vertical", moveDir.y);

        moveDir.x = Input.GetAxisRaw("Horizontal") * speed;
        moveDir.y =Input.GetAxisRaw("Vertical") * speed;
        rigid.velocity= moveDir;
    }
}
