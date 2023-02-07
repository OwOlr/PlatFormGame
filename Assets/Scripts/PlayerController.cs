using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed=2f;
    float vx = 0;
    float vy = 0;
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
        vy = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            flipFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = speed;
            flipFlag = true;
        }
        if (Input.GetKey("up"))
        {

        }
    }
    private void FixedUpdate()
    {
        playerRigid.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = flipFlag;
    }
}
