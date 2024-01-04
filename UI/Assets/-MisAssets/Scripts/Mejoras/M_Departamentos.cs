using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class M_Departamentos : MonoBehaviour
{
    public float DepartamentoNumero;
    public float DepartamentoCoste;
    public float DepartamentoBPS;

    public Text DepartamentoNumeroDisp;
    public Text DepartamentoCosteDisp;
    public Text DepartamentoBPSDisp;
    public Click CK;

    void Start()
    {
        DepartamentoCoste = 60;
        
    }

    void Update()
    {
        DepartamentoNumeroDisp.text = "" + DepartamentoNumero;
        DepartamentoCosteDisp.text = "" + DepartamentoCoste;
        DepartamentoBPSDisp.text=""+ DepartamentoBPS;

        //MultipliCasas

        DepartamentoBPS = 7* DepartamentoNumero;

        CK.Dinero += DepartamentoBPS / 100;



    }
    public void ComprarDepartamentos()
    {
        if (CK.Dinero >= 60)
        {
            DepartamentoNumero += 1;
            CK.Dinero -= 60;
        }

    }
}
