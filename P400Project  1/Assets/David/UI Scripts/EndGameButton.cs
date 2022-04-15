using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButton : MonoBehaviour
{
    public void EndGame()
    {
        Locator.Get.Messenger.OnReceiveMessage(MessageType.EndGame, null);
    }
}
