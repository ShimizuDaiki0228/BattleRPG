using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    [SerializeField] //privateにするならつけといた方が良さそう
    private GameObject gameOverPauseUI;
    [SerializeField] //privateにするならつけといた方が良さそう
    private GameObject gameClearPauseUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOverPauseWait()
    {
      Invoke("GameOverPause", 3f);
    }

    public void GameOverPause()
    {
      gameOverPauseUI.SetActive(true);
      
      if(gameOverPauseUI.activeSelf)
      {
        Time.timeScale = 0f;
      }
    }

    public void GameClearPauseWait()
    {
      Invoke("GameClearPause", 3f);
    }

    public void GameClearPause()
    {
      gameClearPauseUI.SetActive(true);
      
      if(gameClearPauseUI.activeSelf)
      {
        Time.timeScale = 0f;
      }
    }
}
