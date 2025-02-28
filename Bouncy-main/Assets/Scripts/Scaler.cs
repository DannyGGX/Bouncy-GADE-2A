using System;
using System.Threading.Tasks;
using UnityEngine;

namespace DefaultNamespace
{
    
    public class Scaler : MonoBehaviour
    {
        [SerializeField, Tooltip("x scale over time in seconds")] private AnimationCurve xScaleCurve;
        [SerializeField] private AnimationCurve zScaleCurve;
        [SerializeField] private AnimationCurve yScaleCurve;
        private float currentScaleTime = 0;

        public void StartLoopScaling()
        {
            
        }

        public void StopLoopScaling()
        {
            
        }

        public async void ScaleOnce()
        {
            currentScaleTime = 0;
            float x;
            float y;
            float z;
            while (currentScaleTime < xScaleCurve.length * 100)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(100));
                currentScaleTime += 100;
                x = xScaleCurve.Evaluate(currentScaleTime);
                y = yScaleCurve.Evaluate(currentScaleTime);
                z = zScaleCurve.Evaluate(currentScaleTime);
                transform.localScale = new Vector3(x, y, z);
            }
        }
        
        private void Update()
        {
            
        }
    }
}