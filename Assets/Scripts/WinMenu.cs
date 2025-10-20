using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void ReplayGame()
    {
        // Recharge la scène du jeu principal
        SceneManager.LoadScene("MainScene");
    }

    public void GoToMenu()
    {
        // Retourne au menu principal
        SceneManager.LoadScene("MenuScene");
    }
}
