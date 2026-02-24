using UnityEngine;
using System.Collections.Generic;

public class FruitTracker : MonoBehaviour
{
    public static FruitTracker Instance;

    //insert fruit name AND number
    //i finally searched up how to use a dictionary 
    private Dictionary<string, int> inventory = new Dictionary<string, int>();

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddFruit(string fruitName)
    {
        //set fruit int to zero if new
        if (!inventory.ContainsKey(fruitName))
        {
            inventory[fruitName] = PlayerPrefs.GetInt(fruitName, 0);
        }

        //add  fruit
        inventory[fruitName]++;

        //reference the actual fruits name
        PlayerPrefs.SetInt(fruitName, inventory[fruitName]);
        PlayerPrefs.Save();

        // tracker in the console instead of the tmp bc it fucked me in the ass
        Debug.Log($"ayo you GAINED 1 to {fruitName}. yo total {fruitName}s: {inventory[fruitName]}");
    }
}