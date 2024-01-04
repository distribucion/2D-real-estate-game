using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_C : MonoBehaviour
{
    public float casasNumer;
    public float casasCoste;
    public float casasBPS;

    public Text casasNumerDisp;
    public Text casasCosteDisp;
    public Text casasBPSDisp;
    public Click CK;

    
   
    void Start()
    {
        casasCoste = 70;
        
    }

    
    void Update()
    {
        casasNumerDisp.text = "" + casasNumer;
        casasCosteDisp.text = "" + casasCoste;
        casasBPSDisp.text = "" + casasBPS;

        //MultipliCasas

        casasBPS = 8 * casasNumer;

        CK.Dinero += casasBPS / 100;



    }
    public void ComprarCasas() 
    {
        if (CK.Dinero >= 70) 
        {
            casasNumer += 1;
            CK.Dinero -= 70;

        }

    }
}
