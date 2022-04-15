using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LocalGameStateObserver))]
public class GameStateUIVisibility : ObserverPanel<LocalGameState>
{
    [SerializeField]
    GameState ShowThisWhen;

    public override void ObservedUpdated(LocalGameState observed)
    {
        if (!ShowThisWhen.HasFlag(observed.State))
            Hide();
        else
        {
            Show();
        }
    }
}
