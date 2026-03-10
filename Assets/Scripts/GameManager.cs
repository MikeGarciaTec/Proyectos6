using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager instance;

    public static GameManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public GAME_STATES currentGameState;
    
    public Action<GAME_STATES> OnGameStateChange;

    public void ChangeGameState(GAME_STATES _newGameState)
    {
        if (_newGameState == currentGameState)
            return;

        currentGameState = _newGameState;
        if(OnGameStateChange != null)
            OnGameStateChange(currentGameState);
        
    }
}


public enum GAME_STATES
{
    GAMEPLAY,
    PAUSE,
    TUTORIAL

}