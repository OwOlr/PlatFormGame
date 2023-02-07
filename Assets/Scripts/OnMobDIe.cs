using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMobDIe : MonoBehaviour
{
    public Image gameOverImg;
    public int hitCount=0;
    public Button replayBtn;
    private void Start()
    {
        hitCount = 0;
        gameOverImg.enabled = false;
        replayBtn.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hitCount>=3)
        {
            this.gameObject.SetActive(false);
            hitCount = 0;
        }
        else
        {
            if (collision.gameObject.tag=="Stone")
            {
                GameObject checkObj = GameObject.Find(collision.gameObject.name);
                if (checkObj != null)
                {
                    hitCount++;
                }
            }
        }
        
        
    }
    public void GameOver()
    {
        gameOverImg.enabled = true;
        replayBtn.gameObject.SetActive(true);
        Debug.Log("게임오버!");
        Time.timeScale = 0;
    }
}
