using System;
using Controllers;
using UnityEngine;
using UnityEngine.UI;
using Views;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameController _game;
    public GameController Game => _game;

    [SerializeField] private View _gameOverWindow;
    [SerializeField] private View _menuWindow;
    [SerializeField] private View _bestScoreView;
    [SerializeField] private View _gameWindow;
    
    private GameWindowController _gameWindowController;
    private MenuController _menuController;
    private BestScoreViewController _bestScoreViewController;
    private GameOverWindowController _gameOverWindowController;

    private View _view;

    private void OnEnable()
    {
        _bestScoreViewController = new BestScoreViewController(this);
        _gameOverWindowController = new GameOverWindowController(this);
        _gameWindowController = new GameWindowController(this);
        _menuController = new MenuController(this);
        
        OpenMenu();
    }

    private void Open<T>(View view, IController<T> controller) where T : View
    {
        _view = view;
        _view.Open(controller);
    }

    private void Close<T>(View view, IController<T> controller) where T : View
    {
        if (_view != view) return;
        view.Close(controller);
        _view = null;
    }
    
    public void OpenMenu()
    {
        Open(_menuWindow, _menuController);
    }

    public void OpenGame()
    {
        Open(_gameWindow, _gameWindowController);
    }

    public void OpenGameOver() 
    {
        Open(_gameOverWindow, _gameOverWindowController);
    }

    public void OpenBestScoreView()
    {
        Open(_bestScoreView, _bestScoreViewController);
    }
    
    public void CloseMenu()
    {
        Close(_menuWindow, _menuController);
    }

    public void CloseGameWindow()
    {
        Close(_gameWindow, _gameWindowController);
    }

    public void CloseGameOverWindow()
    {
        Close(_gameOverWindow, _gameOverWindowController);
    }

    public void CloseBestScoreView()
    {
        Close(_bestScoreView, _bestScoreViewController);
    }
}


