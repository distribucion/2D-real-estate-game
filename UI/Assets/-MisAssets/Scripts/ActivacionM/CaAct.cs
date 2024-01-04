using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaAct : MonoBehaviour
{
    public M_Departamentos MD;
    public GameObject ActivaCasas;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (MD.DepartamentoNumero == 1) 
        {
            ActivaCasas.SetActive(true);
        }

        
    }
}
