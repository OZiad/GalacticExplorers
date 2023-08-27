using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState state;
    public static event Action<GameState> OnGameStateChanged;
    private void Awake()
    {
        instance = this;
    }
    public void UpdateGameState(GameState newState)
    {
        state = newState;
        switch (newState)
        {
            case GameState.Victory:
                HandleVictory();
                break;
            case GameState.Defeat:
                HandleDefeat();
                break;
            case GameState.Fight:
                HandleFight();
                break;
            default:
                break;
        }
        OnGameStateChanged?.Invoke(newState);
    }

    private void HandleVictory()
    {
        // MenuManager.Instance.ToggleVictoryScreen(true);
    }
    private void HandleFight()
    {
        // throw new NotImplementedExcepton();
    }

    private void HandleDefeat()
    {
        // MenuManager.Instance.ToggleLoseScreen(true);
    }

}

// All possible game states
public enum GameState
{
    Fight,
    Victory,
    Defeat
}
