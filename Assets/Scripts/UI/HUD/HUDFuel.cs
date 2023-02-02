using System;
using OcarinaStudios.MathRacing.Car.Fuel;
using OcarinaStudios.MathRacing.Service;
using TMPro;
using UnityEngine;

public class HUDFuel : MonoBehaviour
{
    [SerializeField] private TMP_Text _fuelLabel;
    private FuelManager _fuelManager;
    private void Start() => InitializeServices();
    private void InitializeServices()
    {
        _fuelManager = ServiceLocator.Get<FuelManager>();
    }

    private void Update() => UpdateHUD();

    private void UpdateHUD()
    {
        _fuelLabel.text = Mathf.Round(_fuelManager.GetFuelLevel()).ToString();
    }
}
