using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Multiplayer.States.P400.Client
{

    public class ClientMainMenuState : GameStateBehaviour
    {
        public override GameState ActiveState { get { return GameState.MainMenu; } }
    }
}
