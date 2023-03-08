using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject startCanvas;
    
    void Start()
    {
        startCanvas.SetActive(true);
    }

    
    void Update()
    {
        
    }
    public void StartButton() 
    { 
        startCanvas.SetActive(false); 
    
    } 

}
