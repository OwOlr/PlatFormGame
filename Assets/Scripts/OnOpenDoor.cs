using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOpenDoor : MonoBehaviour
{
    public Image claerImg;
    public Button replayBtn;
    public GameObject isMob;
    OnGetKeyCount keyCollected;
    // Start is called before the first frame update
    void Start()
    {
        claerImg.enabled = false;
        replayBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        keyCollected = FindObjectOfType<OnGetKeyCount>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isMob.activeSelf)
        {
            if (collision.tag == "Player"&& keyCollected.keyCount>=3)
            {
                GameObject checkObj = GameObject.Find(collision.gameObject.name);
                if (checkObj!=null)
                {
                    claerImg.enabled = true;
                    replayBtn.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
            }     
        }
        
    }
}
