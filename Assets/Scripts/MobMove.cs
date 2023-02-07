using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMove : MonoBehaviour
{

    Rigidbody2D mobRigd;

    public bool flipFlag = false;
    public float mspeed = 2;
    float vx = 0;

    // Start is called before the first frame update
    void Start()
    {
        mobRigd = GetComponent<Rigidbody2D>();
        mobRigd.constraints = RigidbodyConstraints2D.FreezeRotation; 
    }
    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (flipFlag)
        {
            vx = -mspeed;
        }
        else
        {
            vx = mspeed;
        }
    }
    private void FixedUpdate()
    {
        mobRigd.velocity = new Vector2(vx, 0);
        this.GetComponent<SpriteRenderer>().flipX = flipFlag;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flipFlag = !flipFlag;
    }
}
