using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAttack : MonoBehaviour
{
    bool leftFlag = false;
    bool pushFlag = false;

    public float throwX = 4;
    public float throwY = 8;
    public float offsetX = 1;

    public GameObject stonePrefeb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey("right"))
        {
            leftFlag = false;
        }

        if (Input.GetKey("left"))
        {
            leftFlag = true;
        }
        if (Input.GetKey("space"))
        {
            if (pushFlag == false)
            {

                pushFlag = true;
                Vector3 playerPos = this.transform.position;

                GameObject attackObj = Instantiate(stonePrefeb) as GameObject;
                Rigidbody2D attackObjRigid = attackObj.GetComponent<Rigidbody2D>();

                if (leftFlag)
                {
                    playerPos.x -= offsetX;
                    attackObj.transform.position = playerPos;
                    attackObjRigid.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);

                }
                else
                {
                    playerPos.x += offsetX;
                    attackObj.transform.position = playerPos;
                    attackObjRigid.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
                }

            }
        }
        else
        {
            pushFlag = false;
        }
    }
 
}
