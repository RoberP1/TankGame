using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayers : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    private void Update()
    {
        transform.position = ((player1.position - player2.position) / 2 )+ player2.position;
    }
    public void Player1Dead()
    {
        player1 = player2;
    }
    public void Player2Dead()
    {
        player2 = player1;
    }
}
