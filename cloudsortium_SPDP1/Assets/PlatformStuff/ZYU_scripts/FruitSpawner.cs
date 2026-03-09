using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public FruitData[] possibleMelo; 
    public GameObject meloPrefab;    

    void Start()
    {
        SpawnRandom();
    }

    public void SpawnRandom()
    { 
        int index = Random.Range(0, possibleMelo.Length);
        FruitData randomData = possibleMelo[index];
        GameObject newFruit = Instantiate(meloPrefab, transform.position, Quaternion.identity);
        newFruit.GetComponent<Melodrop>().fruitData = randomData;
        newFruit.transform.SetParent(this.transform);
    }
}