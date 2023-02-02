using UnityEngine;

namespace OcarinaStudios.MathRacing.Car
{
    public class CarInputHandler: MonoBehaviour, ICarInputHandler
    {
        public float HorizontalInput => Input.GetAxis("Horizontal");
        public float VerticalInput => Input.GetAxis("Vertical");
    }
}