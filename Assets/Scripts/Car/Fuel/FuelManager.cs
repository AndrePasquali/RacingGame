using System;
using OcarinaStudios.MathRacing.Service;
using OcarinaStudios.MathRacing.Settings;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Car.Fuel
{
    public class FuelManager: MonoBehaviour, IFuelManager
    {
        private GameSettings _gameSettings;
        private float _fuelLevel;
        
        private bool _isFuelEmpty;

        [SerializeField] private CarDistance _carDistance;

        public event Action OnFuelEmpty;

        private void Start() => InitializeServices();
        private void Update() => UpdateFuel();

        private void InitializeServices()
        {
            _gameSettings = ServiceLocator.Get<GameSettings>();

           FillFuel();
        }

        public void UpdateFuel()
        {
            if (_isFuelEmpty) return;
            
            _fuelLevel -= Mathf.Clamp( _carDistance.GetDistanceTravelled() / _gameSettings.CarSettings.FuelAutonomy, 0, _gameSettings.CarSettings.FuelCapacity );

            if (_fuelLevel <= 0)
            {
                _isFuelEmpty = true;
                OnFuelEmpty?.Invoke();
            }
        }

        public bool IsFuelEmpty()
        {
            return _isFuelEmpty;
        }

        public void FillFuel()
        {
            _fuelLevel = _gameSettings.CarSettings.FuelCapacity;
            _isFuelEmpty = false;
        }

        public int GetFuelLevel()
        {
            return (int)_fuelLevel;
        }
    }
}