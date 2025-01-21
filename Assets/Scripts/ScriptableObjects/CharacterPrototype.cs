using UnityEngine;

[CreateAssetMenu(fileName = "CharacterPrototype", menuName = "Scriptable Objects/CharacterPrototype")]

/*
 * The base stats of a type of character at level 1
 * The level and stats changes are implemented in individual characters
 */

public class CharacterPrototype : ScriptableObject
{
    // The name of this type of character (Ex. Nerd)
    // NOT the name of the character (Ex. Miku)
    public string CharacterType; // ---- make this an enum ------
    public ElementType type; 

    // The basic stats at level 1
    public int baseAttack;
    public int baseDefense;
    public int baseHealth;
    public int baseSpeed;

    // List of avaliable moves
    public Move[] Moves;

    // Future addition: 
    // public AnimationController[] animation controller 
    // bascially random sprite & animation
}
