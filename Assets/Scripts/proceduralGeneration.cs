using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralGeneration : MonoBehaviour
{
    private const float PLAYER_DISTANCE=50f;

    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private Player player;

    private Vector3 lastEndPosition;
    // Start is called before the first frame update
    void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;

        int startingSpawnLevelParts = 5;
        for(int i =0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if (Vector3.Distance(player.GetPosition(), lastEndPosition) < PLAYER_DISTANCE)
        {
            SpawnLevelPart();
        }
    }
    
    void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart,lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    { 
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}