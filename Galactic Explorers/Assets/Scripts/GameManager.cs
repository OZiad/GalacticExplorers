using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
This script controls the flow of the game, taking appropriate action depending on the game state.
The other manager scripts communicate the current game state to the game manager script

Example: GameManager.Instance.UpdateGameState(GameState.Victory) 
*/

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState state;
    public static event Action<GameState> OnGameStateChanged;
    private void Awake()
    {
        Instance = this;
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
        MenuManager.Instance.ToggleVictoryScreen(true);
        SceneManager.LoadScene(0);

    }
    private void HandleFight()
    {
        // throw new NotImplementedExcepton();
    }

    private void HandleDefeat()
    {
        MenuManager.Instance.ToggleLoseScreen(true);
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
