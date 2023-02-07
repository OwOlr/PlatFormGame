using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnKeyUI : MonoBehaviour
{
    
    public Image keyUImg1;
    public Image keyUImg2;
    Color keyColor;



    // Start is called before the first frame update
    void Start()
    {
        
        
        keyColor = new Color(1f, 1f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        OnGetKeyCount onGetKeyCount = GetComponent<OnGetKeyCount>();
        switch (onGetKeyCount.keyCount)
        {
            case 1:
                this.GetComponent<Image>().color = keyColor;
                break;
            case 2:
                keyUImg1.GetComponent<Image>().color = keyColor;
                break;
            case 3:
                keyUImg2.GetComponent<Image>().color = keyColor;
                break;

            default:
                break;
        }

    }
}
