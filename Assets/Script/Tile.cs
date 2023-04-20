using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

   public SelectTile GameManager { get; set; }
    public virtual int Score { get; }

    private void Start() {
        GameManager = FindObjectOfType<SelectTile>();
    }
}
