using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingeltonGenerik<UIManager>
{
    [SerializeField] GameObject GameCanvas;
    [SerializeField] GameObject StartBtn;
    [SerializeField] GameObject ReplayBtn;
    [SerializeField] GameObject NextLevelBtn;
    [SerializeField] Slider ChargeOfSilider;
    [SerializeField] Text enemyToverHeal;
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += GameOverUI;
        GameManager.Instance.OnWin += WinUI;
       
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= GameOverUI;
        GameManager.Instance.OnWin -= WinUI;
       
    }
    private void Start()
    {
        StartUI();
    }
    void GameOverUI()
    {
        GameCanvas.SetActive(true);
        Time.timeScale = 0;
        StartBtn.SetActive(false);
        ReplayBtn.SetActive(true);
        NextLevelBtn.SetActive(false);
    }
    void WinUI()
    {
        GameCanvas.SetActive(true);
        Time.timeScale = 0;
        StartBtn.SetActive(false);
        ReplayBtn.SetActive(false);
        NextLevelBtn.SetActive(true);
    }
    void StartUI()
    {
        GameCanvas.SetActive(true);
        StartBtn.SetActive(true);
        ReplayBtn.SetActive(false);
        NextLevelBtn.SetActive(false);
        Time.timeScale = 0;
    }
   public void BigBrotherSiliderChange(int cahrge)
    {
        ChargeOfSilider.value = cahrge;
    }
    public void TowerHealtText(int healt)
    {
        enemyToverHeal.text = healt.ToString();
    }
}
