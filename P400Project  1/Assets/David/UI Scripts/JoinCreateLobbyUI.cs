using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum JoinCreateTabs
{
    Join,
    Create
}

public class JoinCreateLobbyUI : ObserverPanel<LocalGameState>
{
    public UnityEvent<JoinCreateTabs> m_OnTabChanged;

    [SerializeField] //Serialized for Visisbility in Editor
    JoinCreateTabs m_CurrentTab = JoinCreateTabs.Join;

    public JoinCreateTabs CurrentTab
    {
        get => m_CurrentTab;
        set
        {
            m_CurrentTab = value;
            m_OnTabChanged?.Invoke(m_CurrentTab);
        }
    }

    public void SetJoinTab()
    {
        CurrentTab = JoinCreateTabs.Join;
    }

    public void SetCreateTab()
    {
        CurrentTab = JoinCreateTabs.Create;
    }

    public override void ObservedUpdated(LocalGameState observed)
    {
        if (observed.State == GameState.JoinMenu)
        {
            m_OnTabChanged?.Invoke(m_CurrentTab);
            Show(false);
        }
        else
        {
            Hide();
        }
    }
}
