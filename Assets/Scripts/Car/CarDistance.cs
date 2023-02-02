using System;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Car
{
    public class CarDistance: MonoBehaviour, ICarDistance
    {
        private float _distanceTravelled;
        private Vector3 _startPosition;

        public float GetDistanceTravelled() => Mathf.Round(_distanceTravelled);

        private void Start()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            _distanceTravelled = Vector3.Distance(_startPosition, transform.position);
        }
    }
}