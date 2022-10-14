using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField, Tooltip("When they drop to 0, the character is considered dead.")]
    ushort hp;
    [SerializeField, Tooltip("They are used to execute tandem attacks.")]
    ushort ap;
    [SerializeField, Tooltip("It determines how much damage is dealt to enemies.")]
    ushort attack;
    [SerializeField, Tooltip("It determines how much damage is recieved from enemy attacks.")]
    ushort defense;
    [SerializeField, Tooltip("It determines the order of the turns.")]
    ushort speed;
    [SerializeField, Tooltip("It determines the chance of critical hit and enduring deadly hits with 1 HP")]
    ushort luck;

    ushort currentHP;
    ushort currentAP;
    float inverseSpeed;
    float nextTurn;

    bool myTurn;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTurn()
    {
        myTurn = true;
    }

    public void EndTurn()
    {

    }
}
