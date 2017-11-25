using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	// This will allow us to drag an image into this slot - Brackeys
	public Texture2D map;

	// Use this for initialization
	void Start () {
		GenerateLevel();
	}

	void GenerateLevel()
	{
		for (int x = 0; x < map.width; x++)
		{
			for (int y = 0; y < map.height; y++)
			{
				GenerateTile(x, y);
			}
		}
	}

	void GenerateTile(int x, int y)
	{
		// Get color at pixel on image
		Color pixelColor = map.GetPixel(x, y);

		if (pixelColor.a == 0)
		{
			// alpha is 0, pixel is transparent so ignore it
			return;
		}

		Debug.Log(pixelColor);
	}
	
}
