using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public Vector2Int index;

    public bool isforward = true;
    public bool isback = true;
    public bool isleft = true;
    public bool isright = true;
    // Start is called before the first frame update

    public GameObject forward;
    public GameObject back;
    public GameObject left;
    public GameObject right;

    void Start()
    {
        ShowWalls();
    }

    
    public void ShowWalls()
    {
        forward.SetActive(isforward);
        back.SetActive(isback);
        right.SetActive(isright);
        left.SetActive(isleft);
    }
    public bool CheckAllWalls()
    {
        return isforward && isback && isleft && isright;
    }
}
