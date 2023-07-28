using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public int index;
    public int player;
    public int type;

    public static int PAWN = 0;
    public static int ROOK = 1;
    public static int KNIGHT = 2;
    public static int BISHOP = 3;
    public static int QUEEN = 4;
    public static int KING = 5;




    public void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    
    

}
