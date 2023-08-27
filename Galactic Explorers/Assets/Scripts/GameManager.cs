using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        MenuManager.instance.ToggleVictoryScreen(true);

    }
    private void HandleFight()
    {
        // throw new NotImplementedExcepton();
    }

    private void HandleDefeat()
    {
        MenuManager.instance.ToggleLoseScreen(true);
        SceneManager.LoadScene(0);
    }

}

// All possible game states
public enum GameState
{
    Fight,
    Victory,
    Defeat
}
