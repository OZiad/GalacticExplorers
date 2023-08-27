using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    void Awake()
    {
        instance = this;
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
    }
    void Start()
    {

    }
    void Update()
    {

    }
    private void GameManagerOnGameStateChanged(GameState state)
    {

    }

    internal void ToggleLoseScreen(bool v)
    {
        throw new NotImplementedException();
    }
    internal void ToggleVictoryScreen(bool v)

    {
        throw new NotImplementedException();
    }
}
