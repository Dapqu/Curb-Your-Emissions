using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPuased = false;

    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject controlsMenu;
    [SerializeField]
    private GameObject audioMenu;


    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (gameIsPuased) {
                if (pauseMenu.active) {
                    Resume();
                }
                if (controlsMenu.active) {
                    pauseMenu.SetActive(true);
                    controlsMenu.SetActive(false);
                }
                if (audioMenu.active) {
                    pauseMenu.SetActive(true);
                    audioMenu.SetActive(false);
                }
            }
            else {
                Pause();
            }
        }
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        gameIsPuased = false;
    }

    void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPuased = true;
    }

    public void QuitGame() {
        Debug.Log("Quitting Game!");
        Application.Quit();
    }
}
