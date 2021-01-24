﻿using UnityEngine;
using System.Collections.Generic;

public class WayPointManager : MonoBehaviour
{
    //1
    public static WayPointManager Instance;
    //2
    public List<EnemyPath> Paths = new List<EnemyPath>();

    void Awake()
    {
        //3
        Instance = this;
    }

    //4
    public Vector3 GetSpawnPosition(int pathIndex)
    {
        return Paths[pathIndex].WayPoints[0].position;
    }

}

//5
[System.Serializable]
public class EnemyPath
{
    public List<Transform> WayPoints = new List<Transform>();
}