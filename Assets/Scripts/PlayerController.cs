using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed=2f;
    public float jumpPower = 5f;
    float vx = 0;
    Rigidbody2D playerRigid;

    bool flipFlag = false;

    bool pushFlag = false;
    bool jumpFlag = false;
    bool groundFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
        playerRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            flipFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            flipFlag = true;
        }
        //groundFlag�� 1�� ������ ��� (������ ��Ÿ ��������)
        if (Input.GetKey("up")&&groundFlag)
        {
            //�ٿ� ������ �� ���� ���� ����.
            if (pushFlag ==false)
            {
                jumpFlag = true;
                pushFlag = true;
            }
        }
        else
        {
            pushFlag = false;
        }
    }
    private void FixedUpdate()
    {
        playerRigid.velocity = new Vector2(vx, playerRigid.velocity.y);
        this.GetComponent<SpriteRenderer>().flipX = flipFlag;
        if (jumpFlag)
        {
            jumpFlag = false;
            playerRigid.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        groundFlag = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        groundFlag = false;
    }
}
