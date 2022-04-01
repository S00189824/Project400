using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyNameUI : ObserverPanel<LocalLobby>
{
    [SerializeField]
    TMP_Text m_lobbyNameText;

    public override void ObservedUpdated(LocalLobby observed)
    {
        m_lobbyNameText.SetText(observed.LobbyName);
    }
}
