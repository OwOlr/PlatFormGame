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
        //groundFlag로 1단 점프만 허용 (여러번 연타 점프제한)
        if (Input.GetKey("up")&&groundFlag)
        {
            //꾸욱 눌렀을 때 연속 점프 제한.
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
