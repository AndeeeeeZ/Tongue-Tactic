using UnityEngine;
using UnityEngine.Rendering;

public class BattleController : MonoBehaviour
{

    /*
     * Input system
     * 
     * Damage & move effect calculation
     * 
     * Holding pointer to opponent and player
     * 
     * Battle cycle: 
     * queue for whose turn is next
     * counting the turn pass left
     */

    [SerializeField] Character player, opponent; 

    public void SwitchTurn()
    {

    }

    public void Input(int moveIndex)
    {
        DamageCalculation(player.characterPrototype.Moves[moveIndex], opponent);
    }

    private void DamageCalculation(Move move, Character target)
    {

    }


}
