using System;
using UnityEngine;


public class SelectTile : MonoBehaviour {
    
    public event EventHandler<TileSelectEventArgs> OnTileSelect;
    public class TileSelectEventArgs : EventArgs {
        public Tile tile { get; }
        public TileSelectEventArgs(Tile tile) {
            this.tile = tile;
        }

    }
    public void TileSelect(GameObject image) {
        Tile selectedTile = image.GetComponentInParent<Tile>();
        OnTileSelect?.Invoke(this,new TileSelectEventArgs(selectedTile));
        image.SetActive(false);
    }
}
