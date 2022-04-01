using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(LocalLobbyObserver))]

public class LobbyButtonUI : MonoBehaviour
{
    /// <summary>
    /// Controls an entry in the join menu's list of lobbies, acting as a clickable button as well as displaying info about the lobby.
    /// </summary>
    
    
        [SerializeField]
        TMP_Text lobbyNameText;
        [SerializeField]
        TMP_Text lobbyCountText;

        /// <summary>
        /// Subscribed to on instantiation to pass our lobby data back
        /// </summary>
        public UnityEvent<LocalLobby> onLobbyPressed;
        LocalLobbyObserver m_DataObserver;

        void Awake()
        {
            m_DataObserver = GetComponent<LocalLobbyObserver>();
        }

        /// <summary>
        /// UI CallBack
        /// </summary>
        public void OnLobbyClicked()
        {
            onLobbyPressed?.Invoke(m_DataObserver.observed);
        }

        public void UpdateLobby(LocalLobby lobby)
        {
            m_DataObserver.observed.CopyObserved(lobby);
        }

        public void OnLobbyUpdated(LocalLobby data)
        {
            lobbyNameText.SetText(data.LobbyName);
            lobbyCountText.SetText($"{data.PlayerCount}/{data.MaxPlayerCount}");
        }
    
}
