using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    void Awake() {
        Instance = this;
    }

    public enum Scene
    {
        Menu,
        Game
    }


    public void loadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void loadGame()
    {
        SceneManager.LoadScene(Scene.Game.ToString());
        Debug.Log("I am loading");
    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(Scene.Menu.ToString());
    }

    public void unloadScene(Scene scene)
    {
        SceneManager.UnloadSceneAsync(scene.ToString());
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
