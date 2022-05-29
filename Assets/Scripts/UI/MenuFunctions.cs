using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    [SerializeField] private GameObject logoGame;
    [SerializeField] private GameObject logoPerfectGlitch;
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject creditsButton;
    [SerializeField] private GameObject quitButton;
    [SerializeField] private GameObject villanoFuego;
    [SerializeField] private GameObject villanoHielo;

    private void Start()
    {
        //Main Logo
        LeanTween.scale(logoGame, new Vector3(1, 1, 1), 3f).setEase(LeanTweenType.easeInOutExpo);

        //Villains
        LeanTween.scale(villanoFuego, new Vector3(1.1238f, 1.1238f, 1.1238f), 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(1);
        LeanTween.scale(villanoHielo, new Vector3(1.1238f, 1.1238f, 1.1238f), 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(1);

        //Logo Perfect Glitch
        LeanTween.scale(logoPerfectGlitch, new Vector3(0.9f, 0.9f, 0.9f), 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(7.5f);

        //Buttons
        LeanTween.scale(startButton, new Vector3(1, 1, 1), 1f).setEaseLinear().setDelay(3f);//setEase(LeanTweenType.easeInOutExpo).setDelay(3f);
        LeanTween.scale(creditsButton, new Vector3(1, 1, 1), 1f).setEaseLinear().setDelay(4f);
        LeanTween.scale(quitButton, new Vector3(1, 1, 1), 1f).setEaseLinear().setDelay(5f);
    }

    public void StartGame()
    {
        //SceneManager.LoadScene("MainGame");
        Debug.Log("Llamada a la pantalla del juego principal");
    }

    public void Quit()
    {
        Debug.Log("Cerrar el juego");
        Application.Quit();
    }

    public void Credits()
    {
        //SceneManager.LoadScene("OptionsScreen");
        Debug.Log("Llamada a la pantalla de créditos");
    }
}
