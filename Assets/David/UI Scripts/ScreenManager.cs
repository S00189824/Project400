using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{

    public InputField Email;
    public InputField Password;
    public InputField PasswordConfirmation;


    Transform Canvas;

    void Start()
    {
        Canvas = GameObject.FindObjectOfType<Canvas>().transform;
    }

    
}
