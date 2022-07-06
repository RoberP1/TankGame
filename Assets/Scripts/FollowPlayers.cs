using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayers : MonoBehaviour
{

    public List<Transform> players = new List<Transform>();
    int playersCount;

    public void SetPlayer()
    {
        PlayerInput[] Oplayers =FindObjectsOfType<PlayerInput>();
        for (int i = 0; i < Oplayers.Length; i++)
        {
            if (!players.Contains(Oplayers[i].transform.GetChild(0)))
            {
                players.Add(Oplayers[i].transform.GetChild(0));
            }
           
        }
        playersCount = Oplayers.Length;
    }

    private void Start()
    {
        PlayerInput[] Oplayers = FindObjectsOfType<PlayerInput>();
        for (int i = 0; i < Oplayers.Length; i++)
        {
            players.Add(Oplayers[i].transform.GetChild(0));
        }
        playersCount = Oplayers.Length;
    }
    private void Update()
    {
        //transform.position = ((player1.position - player2.position) / 2 )+ player2.position;

        float x = 0;
        float y = 0;
        float z = 0;
        foreach (var player in players)
        {

                x += player.position.x;
                y += player.position.y;
                z += player.position.z;

        }
        if(playersCount != 0)transform.position = new Vector3(x, y, z) / playersCount;

    }
    public void PlayerDead(Transform playerDead)
    {
        //players[players.IndexOf(playerDead)] = null;
        players.Remove(playerDead);
        FindObjectOfType<LevelManager>().Finish();
    }
    private void OnEnable()
    {
        PlayerInput.OnDie += PlayerDead;
    }
    private void OnDisable()
    {
        PlayerInput.OnDie -= PlayerDead;
    }

}
