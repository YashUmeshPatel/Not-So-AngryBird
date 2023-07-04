using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotate : MonoBehaviour
{
    [SerializeField] List<Transform> endPoints;

    [SerializeField] GameObject player;
    [SerializeField] GameObject target;

    [SerializeField] float duration;
    float startTime = 0;
    int i = 0;

    //private void Start()
    //{
    //    StartCoroutine(MovePlayerCooldown());        
    //}

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 endPoint = ReturnPosition();
        float elapsedTime = startTime / duration;
        LerpPlayer(player.transform.position, endPoint, startTime * Time.deltaTime / duration );        
        if (Vector3.Distance(player.transform.position, endPoint) < 0.05f)
        {
            i++;
        }
    }

    private Vector3 ReturnPosition()
    {        
        return endPoints[i].position;
    }

    private void LerpPlayer(Vector3 startPosition, Vector3 endposition, float duration)
    {
        float elapsedTime = startTime / duration;
        player.transform.position = Vector3.Lerp(startPosition, endposition, elapsedTime);
        startTime += Time.deltaTime;
        //Vector3.MoveTowards(startPosition, endposition, Time.deltaTime / duration);
    }

    IEnumerator MovePlayerCooldown()
    {
        while (true)
        {
            MovePlayer();
            yield return null;
        }
    }

    void Move()
    {
        float elapsedTime = startTime / duration;
        player.transform.position = Vector3.Lerp(player.transform.position, target.transform.position, elapsedTime);
        startTime += Time.deltaTime;
        //player.transform.Translate(Vector3.up * Time.deltaTime);
    }

    void LerpTest()
    {
        Debug.Log(startTime / duration);
        startTime += Time.deltaTime;
        Vector3.Lerp(player.transform.position, target.transform.position, Time.deltaTime / duration);
    }
}
