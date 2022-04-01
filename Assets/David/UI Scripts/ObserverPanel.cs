using LobbyRelay;
using LobbyRelay.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObserverPanel<T> : UIPanelBase where T : Observed<T>
{
    public abstract void ObservedUpdated(T observed);
}
