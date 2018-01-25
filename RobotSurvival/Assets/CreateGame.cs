using UnityEngine;

public class CreateGame : MonoBehaviour {

    private string newMapSize;
    private string newGameMode;

    public void SetMapSize(string mapsize)
    {
        newMapSize = mapsize;
    }

    public void SetGameMode(string gameMode)
    {
        newGameMode = gameMode;
    }

    public void CreateMap()
    {
        Debug.Log(newMapSize + newGameMode);
    }

}
