using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Scriptable Objects/Move")]
public class Move : ScriptableObject
{
    public string moveName;
    public ElementType elementType;
    public MoveType moveType; 

    public int levelRequirement; 
    public int baseDamage;

    // Lines that will be randomly chosen and present as animation
    public string[] lines;
}
