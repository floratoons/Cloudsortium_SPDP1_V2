using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Items")]
public class SongCreationItem : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public AudioClip soundClip;
}