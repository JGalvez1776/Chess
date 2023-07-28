using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.UI.Board.Theme;
using UnityEngine;

public class Board : MonoBehaviour
{

    private GameObject _squarePrefab;
    private GameObject _piecePrefab;

    private Theme theme;
    private Square[] squares;

    public static int WHITE = 0;
    public static int BLACK = 1;

    public void Awake() {
        theme = GetComponentInParent<Theme>();
        initSquares();
    }
    private void initSquares() {
        squares = GetComponentsInChildren<Square>();
        int index = 0;
        // Get all squares
        foreach (Square square in squares) {
            // Link square to the board
            square.theme = theme;
            square.index = index;
            index++;
        }
    }

    [ContextMenu("Show Text")]
    void showText() {
        foreach (Square square in squares) {
            square.showText();
        }
    }

    [ContextMenu("Hide Text")]
    void hideText() {
        foreach (Square square in squares) {
            square.hideText();
        }
    }

    [ContextMenu("Show Pieces")]
    void showPieces() {
        foreach (Square square in squares) {
            square.showPiece();
        }
    }

    [ContextMenu("Hide Pieces")]
    void hidePieces() {
        foreach (Square square in squares) {
            square.hidePiece();
        }
    }
    
}
