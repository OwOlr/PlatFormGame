using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStones : MonoBehaviour
{
    float destroyTime = 2f;
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, destroyTime);
    }
}
