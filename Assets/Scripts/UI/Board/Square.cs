using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.UI.Board.Theme;
using Assets.Scripts.UI.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
public class Square : MonoBehaviour, ISubscriber
{
    public int index { get; set; }
    public Theme theme { private get; set; }


    TextMeshPro textMeshPro;
    SpriteRenderer spriteRenderer;
    Piece piece;


     

    public void Start() {
        piece = GetComponentInChildren<Piece>();
        Assert.IsNotNull(theme);
        textMeshPro = GetComponentInChildren<TextMeshPro>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        theme.subscribe(this);

        changeColor();

        setText(index.ToString());
        hideText();

    }
    
    private void changeColor() {
        setColor(getColor());
    }

    private Color getColor() {
        // Get row index
        int rowShift = (index / 8) % 2;
        Color color = index % 2 == rowShift ? theme.darkSquareColor : theme.lightSquareColor;
        return color;

    }

    private void setText(string text) {
        // Get the TMP
        // Set the text
        textMeshPro.text = text;

    }

    public void hideText() {
        textMeshPro.enabled = false;
    }

    public void showText() {
        textMeshPro.enabled = true;
    }

    public void hidePiece() {
        piece.gameObject.SetActive(false);
    }

    public void showPiece() {
        piece.gameObject.SetActive(true);
    }
    
    private void setColor(Color color) {
        // Set the color of the square
        spriteRenderer.color = color;
    }

    public void onEvent(ChessEvent e)
    {
        changeColor();
    }
}
