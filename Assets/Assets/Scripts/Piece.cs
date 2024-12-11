using UnityEngine;

public class Piece : MonoBehaviour
{
    public TetrisBoard tetrisBoard { get; private set; }
    public TetrominoData data { get; private set; }
    public Vector3Int position { get; private set; }
    
    public void Initialize(TetrisBoard tetrisBoard, Vector3Int position, TetrominoData data)
    {
        this.tetrisBoard = tetrisBoard;
        this.data = data;
        this.position = position;
    }
}
