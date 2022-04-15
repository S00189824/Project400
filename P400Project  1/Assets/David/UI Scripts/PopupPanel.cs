using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Multiplayer.P400.Visual
{
    public class PopupPanel : MonoBehaviour
    {
        string m_RelayMainText;
        string m_UnityRelayMainText;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// Called when the user clicks on the cancel button when in a mode where the player is expecting to input something.
        /// Primary responsibility for this method is to reset the UI state.
        /// </summary>
        private void OnCancelClick()
        {
            ResetState();
        }

        /// <summary>
        /// Helper method to help us reset all state for the popup manager.
        /// </summary>
        private void ResetState()
        {

        }
    }
}


