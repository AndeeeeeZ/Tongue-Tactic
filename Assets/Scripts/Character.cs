using UnityEngine;

/*
 * Container of a character's stats
 * Ex. level, health, 
 */

public class Character : MonoBehaviour
{
    public CharacterPrototype characterPrototype;
    public string characterName;
    [SerializeField] bool AI; 

    [Header("Stats")]
    [SerializeField, Min(0)] int level;
    [SerializeField, Min(0)] int attack;
    [SerializeField, Min(0)] int defense;
    [SerializeField, Min(0)] int speed;

    [SerializeField, Min(0)] int maxHP;
    [SerializeField, Min(0)] int maxMP;
    [SerializeField, Min(0)] int currentHP;
    [SerializeField, Min(0)] int currentMP;


    
}
