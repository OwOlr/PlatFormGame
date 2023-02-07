using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OnStart : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    
    private void OnMouseDown()
    {
        
        SceneManager.LoadScene("SampleScene");
    }

}
