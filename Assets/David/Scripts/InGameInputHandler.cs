using LobbyRelay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Something that will handle player input while in the game.
/// </summary>
public interface IInGameInputHandler : IProvidable<IInGameInputHandler>
{
    void OnPlayerInput(ulong playerId, SymbolObject selectedSymbol);
}

public class InGameInputHandler : IInGameInputHandler
{
    public void OnPlayerInput(ulong playerId, SymbolObject selectedSymbol) { }
    public void OnReProvided(IInGameInputHandler previousProvider) { }
}
