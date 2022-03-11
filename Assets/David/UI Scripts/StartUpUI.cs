using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUpUI : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
