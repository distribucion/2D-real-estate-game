using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_trabajadores : MonoBehaviour

{
    public float TrabajadoresNumeros;
    public float TrabajadoresCoste;
    public float TrabajadoresBPS;

    public Text TrabajadoresNumeroDisp;
    public Text TrabajadoresCosteDisp;
    public Text TrabajadoresBPSDisp;
    public Click CK;


  
    void Start()
    {
        TrabajadoresCoste = 10;
        
    }

   
    void Update()
    {
        TrabajadoresNumeroDisp.text = "" + TrabajadoresNumeros;
        TrabajadoresCosteDisp.text = "" + TrabajadoresCoste;
        TrabajadoresBPSDisp.text = "" + TrabajadoresBPS;

        //Multiplicar personal
        TrabajadoresBPS = 1 * TrabajadoresNumeros;
        CK.Dinero += TrabajadoresBPS / 100;







    }
    public void ContratoTrabajadores() 
    {
        if (CK.Dinero >= 10) 
        {
            TrabajadoresNumeros += 1;
            CK.Dinero -= 10;


        }
    }
}
