using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonUI : MonoBehaviour
{
    public void ToJoinMenu()
    {
        Locator.Get.Messenger.OnReceiveMessage(MessageType.ChangeGameState, GameState.JoinMenu);
    }

    public void ToMenu()
    {
        Locator.Get.Messenger.OnReceiveMessage(MessageType.ChangeGameState, GameState.Menu);
    }
}
