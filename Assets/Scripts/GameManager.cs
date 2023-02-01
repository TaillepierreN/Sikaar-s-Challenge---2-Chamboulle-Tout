using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<Transform> ballSpawns;
    [SerializeField] List<Transform> stackSpawns;
    [SerializeField] GameObject stackPrefab;
    [SerializeField] GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        PrepSpawnStack();
        PrepSpawnBall();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PrepSpawnStack()
    {
        for (int i = 0; i < stackSpawns.Count; i++)
        {
            SpawnStack(stackSpawns[i].transform);
        }
    }
    public void PrepSpawnBall()
    {
        for (int i = 0; i < ballSpawns.Count; i++)
        {
            SpawnBall(ballSpawns[i].transform);
        }
    }
    void SpawnStack(Transform spawnpoint)
    {
        Instantiate(stackPrefab, spawnpoint.position, Quaternion.identity);
    }
    void SpawnBall(Transform spawnpoint)
    {
        Instantiate(ballPrefab, spawnpoint.position, Quaternion.identity);
    }

}
