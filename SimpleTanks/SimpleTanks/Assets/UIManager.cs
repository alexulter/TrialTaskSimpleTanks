using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text TextGameOver;
    public Button ButtonRestart;
    public GameObject GameOverUI;

    void Start () {
        GameManager.Instance.UIManager = this;
        OnGameOver(false);
	}
	
	public void OnGameOver(bool isGameOver)
    {
        GameOverUI.SetActive(isGameOver);
    }
}
