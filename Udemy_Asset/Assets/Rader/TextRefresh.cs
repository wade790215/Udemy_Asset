using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRefresh : MonoBehaviour
{
    public GameObject text; 
    public void ShowText()
    {
        text.SetActive(true); 
        Invoke("HideText", 2f);
    }

    public void HideText()
    {
        text.SetActive(false); 
    }
}
