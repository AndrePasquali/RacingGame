using System;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Settings
{
    [Serializable]
    public class CarSettings
    {
        [Range(5, 100)]
        public int FuelAutonomy = 20;
        [Range(10000, 100000)] 
        public int FuelCapacity = 80000;
        [Range(50, 300)]
        public int MaxSpeed;
        [Range(10, 100)]
        public int Acceleration;
        [Range(10, 100)]
        public int MaxRotationSpeed;
    }
}