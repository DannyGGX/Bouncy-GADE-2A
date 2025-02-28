using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace.RandomlyBreakingObstacles
{
    public class ColumnObjectSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject objectPrefabToSpawn;
        [SerializeField] private int columnCount;
        [SerializeField] private int rowCount;
        [SerializeField] private Transform startingPoint;
        [SerializeField, Tooltip("Offset in relation to the starting point")] private Transform columnOffsetSpacing;
        [SerializeField, Tooltip("Offset in relation to the starting point")] private Transform rowOffsetSpacing;
        private List<GameObject> listOfObjects;

        private void Start()
        {
            listOfObjects = new List<GameObject>();
            SpawnObjects();
        }

        private void SpawnObjects()
        {
            Vector3 columnSpacing = columnOffsetSpacing.localPosition;
            Vector3 rowSpacing = rowOffsetSpacing.localPosition;
            Vector3 startingPosition = startingPoint.position;
            for (int col = 0; col < columnCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    GameObject obj = Instantiate(objectPrefabToSpawn, startingPosition + columnSpacing * col + rowSpacing * row, Quaternion.identity, transform);
                    listOfObjects.Add(obj);
                }
            }
        }
    }
}