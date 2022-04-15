using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonUI : MonoBehaviour
{
    public void ExitApplication()
    {
        Debug.Log("Quit successful");
        Application.Quit();
    }
}
