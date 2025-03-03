using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;

    void Start()
    {

    }
    void Update()
    {
        transform.position = player.transform.position;
    }
}
