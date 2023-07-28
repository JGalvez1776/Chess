using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.UI.Board.Theme;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField]
    private SpriteHandler spriteHandler;

    [SerializeField]
    private Theme theme;

    [SerializeField]
    private EngineController engine;
    
    private Board board;


    void Awake() {
        board = GetComponentInChildren<Board>();
    }
    
    void Start() {
        // TODO: HERE
        // Set the theme

        // Start the engine
        // Put pieces on board
        // Start the game/timer  
    }

}
