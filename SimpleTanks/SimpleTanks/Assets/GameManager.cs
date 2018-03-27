using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;
    [System.NonSerialized]
    public PlayerUnit PlayerUnit;
    [System.NonSerialized]
    public UIManager UIManager;
    public bool IsGameRunning = true;

    private void Awake()
    {
        if (Instance) { Destroy(gameObject); return; }
        Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (!PlayerUnit) { return; }
		if (!PlayerUnit.IsAlive && IsGameRunning)
        {
            Time.timeScale = 0f;
            IsGameRunning = false;
            UIManager.OnGameOver(true);
        }
	}

    public void GameRestart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
