using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class SimpleScaleOnInput : MonoBehaviour
    {

        [FormerlySerializedAs("pulseScale")] [SerializeField] private Scaler scaler;

        private void Awake()
        {
            scaler = GetComponent<Scaler>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                Scale();
            }
        }

        public void Scale()
        {
            scaler.ScaleOnce();
        }
    }
}