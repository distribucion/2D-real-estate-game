using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeActiv : MonoBehaviour
{
    public M_Terrenos MT;
    public GameObject ActivaDepart;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (MT.TerrenosNume == 1) 
        {
            ActivaDepart.SetActive(true);

        }

        
    }
}
