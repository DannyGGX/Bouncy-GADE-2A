using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace.RandomlyBreakingObstacles
{
    public class BreakableObstacle : MonoBehaviour
    {
        private bool willBreak;

        private void Start()
        {
            if (Random.Range(0, 2) == 0)
            {
                willBreak = true;
            }
            else
            {
                willBreak = false;
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (willBreak)
            {
                Destroy(gameObject);
            }
        }
    }
}