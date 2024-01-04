using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public float Dinero;
    public Text DineroDisplay;

    
    private void Update()
    {
        DineroDisplay.text=""+Mathf.Round(Dinero);
        
    }

    
    public void ClickDinero()
    {
        Dinero += 1;
        
    }
}
