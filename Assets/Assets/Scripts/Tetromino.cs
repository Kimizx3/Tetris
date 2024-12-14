using UnityEngine.Tilemaps;
using UnityEngine;
public enum Tetromino
{
    I, J, L, O, S, T, Z
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tiles;
    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] WallKicks { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
        this.WallKicks = Data.WallKicks[this.tetromino];
    }
}
