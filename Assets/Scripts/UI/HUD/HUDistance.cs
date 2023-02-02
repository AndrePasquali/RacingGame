using System;
using OcarinaStudios.MathRacing.Car;
using OcarinaStudios.MathRacing.Service;
using TMPro;
using UnityEngine;

namespace OcarinaStudios.MathRacing.UI.HUD
{
    public class HUDistance: MonoBehaviour
    {
        private CarDistance _carDistance;
        [SerializeField] private TMP_Text _distanceLabel;

        private void Start() => InitializeServices();
        
        private void InitializeServices()
        {
            _carDistance = ServiceLocator.Get<CarDistance>();
        }

        private void Update() => UpdateHud();

        private void UpdateHud()
        {
            _distanceLabel.text = _carDistance.GetDistanceTravelled().ToString();
        }

    }
}