using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Invector.vCharacterController;

[RequireComponent(typeof(AudioSource))]
public class Movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotSpeed = 100f;
    public int turn = 0;
    public bool isOk = false;
    public Vector3 firstWall = new Vector3(0f, 0f, 0f);
    public Vector3 tmp = new Vector3 (0f, 0f, 0f);
    public float volume = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (isOk == false)
        {
            StartCoroutine(Wander());
        }
        /*transform.position += transform.forward * moveSpeed * Time.deltaTime;*/
    }

    IEnumerator Wander()
    {
        isOk = true;
        tmp = transform.position;
        yield return new WaitForSeconds(0.5f);
        float x = tmp.x - transform.position.x;
        float z = tmp.z - transform.position.z;
        if (x < 0.5 && x > -0.5 && z < 0.5 && z > -0.5)
        {
            tmp = new Vector3(0f, 0f, 0f);
            turn += 1;
            if (turn != 4)
            {
                if (firstWall.x == 0.0f)
                {
                    firstWall = transform.position;
                }
                transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            }
            else if ((firstWall.x - transform.position.x) < 0.3 && (firstWall.x - transform.position.x) > -0.5 && (firstWall.y - transform.position.y) < 0.5 && (firstWall.y - transform.position.y) > -0.5)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                turn = 0;
                firstWall = new Vector3(0f, 0f, 0f);
            }
            else
            {
                transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                turn = 0;
                firstWall = new Vector3(0f, 0f, 0f);
            }
        }
        isOk = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Mino")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(audio.clip, volume);
            other.gameObject.GetComponent<vThirdPersonInput>().points++;

            Destroy(gameObject, 2);
        }
    }
}
