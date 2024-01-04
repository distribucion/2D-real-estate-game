using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeActiv : MonoBehaviour
{
    public GameObject ActivaTerreno;
    
    public M_trabajadores NT;

    void Start()
    {

    }


    void Update()
    {
        if (NT.TrabajadoresNumeros == 3) 
        {
            ActivaTerreno.SetActive(true);
        }
        
    }
}
