using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLobbyButtonUI : MonoBehaviour
{
    public void ToJoinMenu()
    {

        Locator.Get.Messenger.OnReceiveMessage(MessageType.ChangeGameState, GameState.JoinMenu);
        Debug.Log("Lobby ScreenSuccessful");
    }
}
