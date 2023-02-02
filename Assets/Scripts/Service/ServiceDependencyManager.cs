using System;
using OcarinaStudios.MathRacing.Car;
using OcarinaStudios.MathRacing.Car.Fuel;
using OcarinaStudios.MathRacing.Game;
using OcarinaStudios.MathRacing.Settings;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Service
{
    public class ServiceDependencyManager: MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private GameSettings _gameSettings;
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private FuelManager _fuelManager;
        [SerializeField] private CarDistance _carDistance;

        private void Awake()
        {
            ServiceLocator.Register(_gameSettings);
            ServiceLocator.Register(_fuelManager);
            ServiceLocator.Register(_carDistance);
            ServiceLocator.Register(_gameManager);
        }
    }
}