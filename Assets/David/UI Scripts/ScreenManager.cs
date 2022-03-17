using LobbyRelay.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Unity.Multiplayer.P400.Visual
{

    [RequireComponent(typeof(CanvasGroup))]
    public class ScreenManager : Singleton<ScreenManager>
    {
        UIPanelBase panelBase;
        Transform Canvas;
        private static ScreenManager s_Instance = null;
        private PopupPanel m_ResponsePopup;

        [SerializeField]
        private Button PlayGame;

        [SerializeField]
        private Button ExitGame;

        GameObject MenuStartScreen;

        void Start()
        {
            Canvas = GameObject.FindObjectOfType<Canvas>().transform;

            MenuStartScreen = GameObject.Find("StartLevel");
        }

        private void Awake()
        {
            Cursor.visible = true;
        }


        public static ScreenManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = FindObjectOfType<ScreenManager>();
                }

                return s_Instance;
            }
        }

        public void OpenMenuScene()
        {
            MenuStartScreen.SetActive(true);
        }
    }
}


