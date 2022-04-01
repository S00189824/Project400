using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RelayAddressUI : ObserverPanel<LocalLobby>
{
    [SerializeField]
    TMP_Text m_IPAddressText;

    public override void ObservedUpdated(LocalLobby observed)
    {
        m_IPAddressText.SetText(observed.RelayServer?.ToString());
    }
}
