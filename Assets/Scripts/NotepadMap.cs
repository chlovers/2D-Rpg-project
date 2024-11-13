using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NotepadMap : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile[] tiles;        
   
    public string mapFilePath = "C:\\eddie shool projects\\unity\\2D Rpg Eddie\\Assets\\Maps\\map 1.txt";

    private void Start()
    {
        LoadPreMadeMap(mapFilePath);
    }

    void LoadPreMadeMap(string mapFilePath)
    {
        string[] maplines = File.ReadAllLines(mapFilePath);
        int width = maplines[0].Length;
        int height = maplines.Length;

        tilemap.ClearAllTiles();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                char tileChar = maplines[y][x];

                Vector3Int tileposition = new Vector3Int(x, -y, 0);
                 
               

                

            }
        }
    }

    void ConvertMapToTileMap()
    {


    }


}
