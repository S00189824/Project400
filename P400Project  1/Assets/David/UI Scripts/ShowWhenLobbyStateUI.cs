using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWhenLobbyStateUI : ObserverPanel<LocalLobby>
{
    [SerializeField]
    private LobbyState m_ShowThisWhen;

    public override void ObservedUpdated(LocalLobby observed)
    {
        if (m_ShowThisWhen.HasFlag(observed.State))
            Show();
        else
            Hide();
    }
}
