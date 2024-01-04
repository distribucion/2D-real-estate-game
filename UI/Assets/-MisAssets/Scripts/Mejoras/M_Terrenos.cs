using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Terrenos : MonoBehaviour
{
    public float TerrenosNume;
    public float TerrenosCoste;
    public float TerrenosBPS;

    public Text TerrenosNumeDisp;
    public Text TerrenosCosteDisp;
    public Text TerrenosBPSDisp;
    public Click CK;

    void Start()
    {
        TerrenosCoste = 20;

    }


    void Update()
    {
        TerrenosNumeDisp.text = "" + TerrenosNume;
        TerrenosCosteDisp.text = "" + TerrenosCoste;
        TerrenosBPSDisp.text = "" + TerrenosBPS;

        //multiplicadordeTerrenos
        TerrenosBPS = 2 * TerrenosNume;
        CK.Dinero += TerrenosBPS / 100;




    }
    public void ComprarTerrenos()
    {
        if (CK.Dinero >= 20) 
        {
            TerrenosNume += 1;
            CK.Dinero   -= 20;

        }
    }
    
    
}
