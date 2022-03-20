using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingeltonGenerik<GameManager>
{

    #region singelton
    private void Awake()
    {
        MakeSingelton(this);
    }
    #endregion
    public event System.Action OnGameOver;
    public event System.Action OnWin;
    public event System.Action OWaveEnd;


    public void GameOver()
    {

        OnGameOver?.Invoke();
    }
    public void GameWin()
    {
        OnWin?.Invoke();
    }
    public void WaveEnd()
    {
        OWaveEnd?.Invoke();
    }
   
}