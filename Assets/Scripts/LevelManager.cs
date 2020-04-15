using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/**
TODOs:
1.!-- Animate Crabs
2.!-- Add Health bars for self and animals
3.!-- Add menu bar for choosing to act on object
4.!-- Animate coconuts to fall and stay on the ground for a couple seconds
5.!-- Add player actions
*/

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tilePrefabs;



    public float TileSize
    {
        get 
        { 
            return tilePrefabs[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateLevel()
    {
        string[] mapData = ReadLevelText();

        int mapX = mapData[0].ToCharArray().Length;
        int mapY = mapData.Length;

        Vector3 worldStart = Camera.main.ScreenToWorldPoint( new Vector3( 0, Screen.height));

        for ( int y = 0; y < mapY; y++ )
        {

            char[] newTiles = mapData[y].ToCharArray();

            for ( int x = 0; x < mapX; x++ )
            {

                PlaceTile( newTiles[x].ToString(), x, y, worldStart  );
                
                if ( newTiles[x].ToString().Equals("4")){

                    PlaceTile( "0", x , y, worldStart  );
                }
            }
        }
    }

    private void PlaceTile( string tileType, int x, int y, Vector3 worldStart)
    {
        int tileIndex = int.Parse(tileType);
        GameObject newTile = Instantiate(tilePrefabs[tileIndex]);
        newTile.transform.position = new Vector3(worldStart.x +  (TileSize * x), worldStart.y - (TileSize * y));
        
        
        
    }

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load("oceantown") as TextAsset;

        string data = bindData.text.Replace(Environment.NewLine, string.Empty);

        return data.Split('-');
    }

}
