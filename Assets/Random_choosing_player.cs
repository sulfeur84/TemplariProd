using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class Random_choosing_player : MonoBehaviour
{
    public List<GameObject> Player = new List<GameObject>();
    private PlayerInputManager manager;

    private bool One;
    // Update is called once per frame
    private void Start()
    {
        One = true;
        int firstPlayer = Random.Range(0, Player.Count);
        manager = GetComponent<PlayerInputManager>();
        manager.playerPrefab = Player[firstPlayer];
        Player.Remove(Player[firstPlayer]);
    }

    private void OnPlayerJoined()
    {
        if(One)
        {
            manager = GetComponent<PlayerInputManager>();
            int nextPlayer = Random.Range(0, Player.Count);
            manager.playerPrefab = Player[nextPlayer];
            Player.Remove(Player[nextPlayer]);
            One = false;
            Invoke("OneReset",0.1f);
        }
    }

    void OneReset()
    {
        One = true;
    }
}
