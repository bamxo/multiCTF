using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.BamDev.CTF
{
    public class MainMenu : MonoBehaviour
    {
        public Launcher launcher;

        private void Start()
        {
            Pause.paused = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void JoinMatch()
        {
            //SceneManager.LoadScene("Map");
            launcher.Join();
        }
        public void CreateMatch()
        {
            launcher.Create();
        }
        public void QuitMatch()
        {
            Application.Quit();
        }
    }
}
