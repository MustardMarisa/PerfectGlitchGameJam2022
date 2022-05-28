using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    public void StartGame()
    {
        //SceneManager.LoadScene("MainGame");
        Debug.Log("Llamada a la pantalla del juego principal");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        //SceneManager.LoadScene("OptionsScreen");
        Debug.Log("Llamada a la pantalla de opciones");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
