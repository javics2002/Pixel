using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    Character[] allies;
    Character[] enemies;

    SortedList<float, Character> turnOrder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBattle(Character[] allyParty, Character[] enemyParty)
    {
        //No es una buena copia en profundidad
        allies = allyParty;
        enemies = enemyParty;

    }

    void NextTurn()
    {

    }
}
