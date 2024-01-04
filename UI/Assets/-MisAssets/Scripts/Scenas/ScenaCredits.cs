using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenaCredits : MonoBehaviour
{
    public Button creditos;

    public void Start()
    {
       creditos.onClick.AddListener(ChangeScene);
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(2);

    }
  
}
