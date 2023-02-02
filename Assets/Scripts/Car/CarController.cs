using OcarinaStudios.MathRacing.Settings;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Car
{
    public class CarController: MonoBehaviour
    {
        private CarMovement _carMovement;
        private CarInputHandler _inputHandler;
        [SerializeField] private GameSettings _settings;

        private void Start() => Initialize();

        private void Initialize()
        {
            _inputHandler = GetComponent<CarInputHandler>();
            _carMovement = GetComponent<CarMovement>();
        }

        private void Update() => EveryFrame();

        private void EveryFrame() => Move();

        private void Move()
        {
            var currentSpeed = _inputHandler.VerticalInput;
            var currentRotation = _inputHandler.HorizontalInput;

            _carMovement.Move(currentSpeed);
            _carMovement.Rotate(currentRotation);
        }
    }
}