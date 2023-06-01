using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public List<Player> players = new List<Player>();

    internal void AssignTurn(int currentPlayerTurn)
    {

        //find the player with id
        Player player = players.Find(x => x.ID == currentPlayerTurn);
        player.myTurn=true;
    }

    // public Player[] playersArray;
    private void Awake() {
        instance = this;
    }


}
