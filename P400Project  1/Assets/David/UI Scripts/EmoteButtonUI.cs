using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteButtonUI : MonoBehaviour
{
    [SerializeField]
    private EmoteType m_emoteType;

    public void SetPlayerEmote()
    {
        Locator.Get.Messenger.OnReceiveMessage(MessageType.UserSetEmote, m_emoteType);
    }
}
