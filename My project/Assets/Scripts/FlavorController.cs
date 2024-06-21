using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlavorController : MonoBehaviour
{
    private TMP_Dropdown colorOptions;
    public Image pastel;

    void Start()
    {
      colorOptions = GetComponent<TMP_Dropdown>();
        pastel = GameObject.Find("Pastel").GetComponent<Image>();
        
    }

    public void ChangeFlavor()
    {
        switch(colorOptions.value)
        {
            case 0:
                pastel.color = Color.black;
                break; 

            case 1:
                pastel.color = Color.yellow;
                break;
                
            case 2:
                pastel.color = Color.magenta;
                break;
        }
    }

   
}
