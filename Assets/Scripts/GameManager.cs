using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<Transform> ballSpawns;
    [SerializeField] List<Transform> stackSpawns;
    [SerializeField] GameObject stackPrefab;
    [SerializeField] GameObject ballPrefab;
    public List<GameObject> spawnedItems;
    [SerializeField] TMP_Text textScore;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        PrepSpawnStack();
        PrepSpawnBall();
        score = 0;

    }
    private void Update() {
        textScore.text = score.ToString();
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
        var spawned = Instantiate(stackPrefab, spawnpoint.position, Quaternion.identity);
        spawnedItems.Add(spawned);
    }
    void SpawnBall(Transform spawnpoint)
    {
        var spawned = Instantiate(ballPrefab, spawnpoint.position, Quaternion.identity);
        spawnedItems.Add(spawned);

    }
    public void Reset()
    {

        foreach (GameObject item in spawnedItems.ToList())
        {
            Destroy(item);
            spawnedItems.Remove(item);
        }
        PrepSpawnStack();
        PrepSpawnBall();
        score = 0;
    }
    public void addPoint()
    {
        score += 5;
    }
    public void addMorePoint()
    {
        score += 5;
    }

}
