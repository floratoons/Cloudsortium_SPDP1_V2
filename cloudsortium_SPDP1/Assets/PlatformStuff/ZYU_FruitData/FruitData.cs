using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[CreateAssetMenu(fileName = "FruitData", menuName = "ScriptableObjects/FruitData")]
public class FruitData : ScriptableObject //use this for all fruit

{
    public string fruitName;
    public Sprite fruitIcon;
    public AudioClip fruitJingle; //for the moosic, comsumables will leave this empty
    public AudioClip pickUp;   
}