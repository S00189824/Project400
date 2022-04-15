using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayersManager : Singleton<PlayersManager>
{
    NetworkVariable<int> playersInGame = new NetworkVariable<int>();

    public int PlayersInGame
    {
        get
        {
            return playersInGame.Value;
        }
    }

    void Start()
    {
        NetworkManager.Singleton.OnClientConnectedCallback += (id) =>
        {
            if (IsServer)
            {
                Logger.Instance.LogInfo($"{id} Just connected. . .");
                playersInGame.Value++;
            }
                
        };

        NetworkManager.Singleton.OnClientDisconnectCallback += (id) =>
        {
            if (IsServer)
            {
                Logger.Instance.LogInfo($"{id} Just Disconnected. . .");
                playersInGame.Value--;

            }
                
        };
    }
}
