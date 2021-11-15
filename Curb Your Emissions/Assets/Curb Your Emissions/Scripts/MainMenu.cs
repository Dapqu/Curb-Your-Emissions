using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject settingsMenu;
    [SerializeField]
    private GameObject controlsMenu;
    [SerializeField]
    private GameObject audioMenu;
    [SerializeField]
    private GameObject creditsMenu;

    void Awake() {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
        controlsMenu.SetActive(false);
        audioMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame() {
        Debug.Log("Exit Game!");
        Application.Quit();
    }

    [System.Obsolete]
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (settingsMenu.active) {
                settingsMenu.SetActive(false);
                mainMenu.SetActive(true);
            }
            if (controlsMenu.active) {
                controlsMenu.SetActive(false);
                settingsMenu.SetActive(true);
            }
            if (audioMenu.active) {
                audioMenu.SetActive(false);
                settingsMenu.SetActive(true);
            }
            if (creditsMenu.active) {
                creditsMenu.SetActive(false);
                settingsMenu.SetActive(true);
            }
        }
    }
}
