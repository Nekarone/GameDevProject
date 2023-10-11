using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Button _newGame;

    // Start is called before the first frame update
    void Start()
    {
        _newGame.onClick.AddListener(startNewGame);
    }

    private void startNewGame()
    {
        //Debug.Log(ScenesManager.Instance);
        ScenesManager.Instance.loadGame();
    }

}
