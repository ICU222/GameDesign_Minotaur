using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotSpeed = 100f;

    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wander());
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotateLorR = Random.Range(1, 4);
        int walkWait = Random.Range(1, 2);

        yield return new WaitForSeconds(walkWait);
        Debug.Log(rotateLorR);
        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }
        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            Debug.Log("test");
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }
    }
}
