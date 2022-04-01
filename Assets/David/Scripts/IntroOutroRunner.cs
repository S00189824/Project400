using LobbyRelay;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroOutroRunner : MonoBehaviour
{
    [SerializeField] private Animator m_animator;
    private Action m_onOutroComplete;

    public void DoIntro()
    {
        m_animator.SetTrigger("DoIntro");
    }

    public void DoOutro(Action onOutroComplete)
    {
        m_onOutroComplete = onOutroComplete;
        m_animator.SetTrigger("DoOutro");
    }

    /// <summary>
    /// Called via an AnimationEvent.
    /// </summary>
    public void OnIntroComplete()
    {
        Locator.Get.Messenger.OnReceiveMessage(MessageType.InstructionsShown, null);
    }
    /// <summary>
    /// Called via an AnimationEvent.
    /// </summary>
    public void OnOutroComplete()
    {
        m_onOutroComplete?.Invoke();
    }
}
