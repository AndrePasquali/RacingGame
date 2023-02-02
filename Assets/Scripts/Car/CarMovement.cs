using OcarinaStudios.MathRacing.Settings;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Car
{
    public class CarMovement: MonoBehaviour
    {
        [SerializeField] private GameSettings _settings;
        
        public void Move(float verticalInput)
        {
            var carSettings = _settings.CarSettings;

            transform.Translate(Vector3.forward * (carSettings.MaxSpeed * verticalInput * Time.deltaTime));
        }

        public void Rotate(float horizontalInput)
        {
            var carSettings = _settings.CarSettings;

            transform.Rotate(Vector3.up,  carSettings.MaxRotationSpeed * horizontalInput * Time.deltaTime);
        }
    }
}