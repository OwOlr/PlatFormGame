using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnGetKeyCount : MonoBehaviour
{
    public int keyCount = 0;
    public bool OnKey = false;
    public bool openFlag = false;

    public Image keyUImg1;
    public Image keyUImg2;
    public Image keyUImg3;
    Color keyColor;

    // Start is called before the first frame update
    void Start()
    {
        keyCount = 0;
        keyColor = new Color(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (keyCount>=3)
        {
            openFlag = true;
        }
        switch (keyCount)
        {
            case 1:
                keyUImg1.GetComponent<Image>().color = keyColor;
                break;
            case 2:
                keyUImg2.GetComponent<Image>().color = keyColor;
                break;
            case 3:
                keyUImg3.GetComponent<Image>().color = keyColor;
                break;

            default:
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            GameObject checkObj = GameObject.Find(collision.gameObject.name);
           
            if (checkObj != null)
            {
                keyCount++;
                collision.gameObject.SetActive(false);
            }
            
        }
    }
   
}
