using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script handles the menu and displays victory and defeat screens
*/


public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    void Awake()
    {
        Instance = this;
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
