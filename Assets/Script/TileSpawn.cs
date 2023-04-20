using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TileSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _tile;
    [SerializeField] private GameObject _grid;
    [SerializeField] private TMP_Text _scoreText;
    SelectTile _selectTile;
    private int _score;
    void Start()
    {
        for (int i = 0; i < 24; i++) {
            Instantiate(_tile[Random.Range(0, _tile.Length)], _grid.transform);
        }
           _selectTile = FindObjectOfType<SelectTile>();
        _selectTile.OnTileSelect += _selectTile_OnTileSelect;
    }

    private void _selectTile_OnTileSelect(object sender, SelectTile.TileSelectEventArgs e) {
        _score += e.tile.Score;
        _scoreText.text = "Score: " + _score.ToString();
    }
}
