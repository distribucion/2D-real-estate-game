using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Button btnMainMenu;

    private void Start()
    {
        btnMainMenu.onClick.AddListener(ChangeScene);
    }
    void ChangeScene() 
    {
        SceneManager.LoadScene(1);

    }

}
