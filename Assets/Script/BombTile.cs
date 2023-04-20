using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BombTile : Tile
{
    private SelectTile _gameManager;
    [SerializeField] GameObject _coverImage;
    private Button _button;
    public override int Score => -1;

    private void Start() {
        _button = GetComponent<Button>();
        _gameManager = FindObjectOfType<SelectTile>();
        _button.onClick.AddListener(delegate { _gameManager.TileSelect(_coverImage); }); 
    }
}
