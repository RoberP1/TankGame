using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayers : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    Transform Transform;

    private void Awake()
    {
        Transform = GetComponent<Transform>();
    }


    private void Update()
    {
        transform.position = ((player1.position - player2.position) / 2 )+ player2.position;
    }
}
