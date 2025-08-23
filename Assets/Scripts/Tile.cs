using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class Tile : MonoBehaviour
{
    public int x;
    public int y;

    private Item _item;

    public Item item
    {
        get => _item;
        set
        {
            if (_item == value) return;

            _item = value;

            icon.sprite = _item.sprite;
        }
    }

    public Image icon;

    public Button button;

    public Tile Left => x > 0 ? Board.Instance.Tiles[x - 1, y] : null;
    public Tile Top => y > 0 ? Board.Instance.Tiles[x, y - 1] : null;
    public Tile Right => x < Board.Instance.Width - 1 ? Board.Instance.Tiles[x + 1, y] : null;
    public Tile Bottom => y > Board.Instance.Height - 1 ? Board.Instance.Tiles[x, y + 1] : null;

    public Tile[] Neighbours => new[]
    {
        Left,
        Top,
        Right,
        Bottom
    };

    private void Start() => button.onClick.AddListener(call: () => Board.Instance.Select(tile: this));

    public List<Tile> GetConnectedTiles(List<Tile> exclude = null)
    {
        var connected = new List<Tile> { this };
        FloodFill(this, connected);
        return connected;
    }

    private void FloodFill(Tile tile, List<Tile> connected)
    {
        var neighbours = GetNeighbors(tile);

        foreach (var neighbour in neighbours)
        {
            if (neighbour.item == tile.item && !connected.Contains(neighbour))
            {
                connected.Add(neighbour);
                FloodFill(neighbour, connected);
            }
        }
    }

    private IEnumerable<Tile> GetNeighbors(Tile tile)
    {
        var dirs = new (int dx, int dy)[] { (1, 0), (-1, 0), (0, 1), (0, -1) };

        foreach (var (dx, dy) in dirs)
        {
            int nx = tile.x + dx;
            int ny = tile.y + dy;

            if (nx >= 0 && nx < Board.Instance.Width &&
                ny >= 0 && ny < Board.Instance.Height)
            {
                yield return Board.Instance.Tiles[nx, ny];
                }
        }
    }
}
