using UnityEngine;

namespace OcarinaStudios.MathRacing.Enviroment
{
    public class DayNightCycle : MonoBehaviour
    {
        public Light DirectionLight => _directionLight ?? (_directionLight = GetComponent<Light>());
        private Light _directionLight;
        public int StartHour = 17;
        public int EndHour = 6;
        public float DayCycleInMinutes = 1;
        private float _currentTime;
        
        void Start()
        {
            _currentTime = StartHour / 24f;
        }

        void Update()
        {
            _currentTime += Time.deltaTime / (DayCycleInMinutes * 60);
            _currentTime %= 1;
            int hour = (int)(_currentTime * 24);
           
            DirectionLight.transform.localRotation = Quaternion.Euler(new Vector3((_currentTime * 360f) - 90, 170, 0));
        }
    }
}
