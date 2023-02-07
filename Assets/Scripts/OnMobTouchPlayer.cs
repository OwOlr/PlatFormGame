using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMobTouchPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject checkObj = GameObject.Find(collision.gameObject.name);
            if (checkObj != null)
            {
                this.GetComponent<OnMobDIe>().GameOver();
            }
        }
    }
}
