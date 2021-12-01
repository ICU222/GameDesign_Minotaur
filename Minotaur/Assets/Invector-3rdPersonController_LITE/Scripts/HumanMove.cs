using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{

    public float moveSpeed = 0.5f;



    // Use this for initialization

    void Start()
    {



    }



    void MoveControl()

    {

        float yMove = moveSpeed * Time.deltaTime;

        transform.Translate(yMove,0, 0);

    }



    // Update is called once per frame

    void Update()

    {

        MoveControl();



    }

}
