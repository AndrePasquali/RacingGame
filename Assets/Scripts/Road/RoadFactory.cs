using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace OcarinaStudios.MathRacing.Road
{
    public class RoadFactory : MonoBehaviour
    {
        public Road[] _roadPrefab; 
        public int _roadLength = 10;
        public int _roadCount;
        private Vector3 _nextPosition;
        public Transform RoadParent;
 
        void Start()
        {
            CreateRoad();
        }
    
        public void CreateRoad()
        {
            _nextPosition = RoadParent.position;
            for (int i = 0; i < _roadCount; i++)
            {
                var road = Instantiate(_roadPrefab[Random.Range(0, _roadPrefab.Length)]);

                switch (road.RoadDirection)
                {
                    case Road.Direction.Forward:
                    {
                        _nextPosition += road.transform.forward * road.Size;
                        break;
                    }
                    case Road.Direction.Left:
                    {
                        //_nextPosition += new Vector3(road.Size, 0, 0);
                        _nextPosition += road.NextSpawnPoint.forward * road.Size;
                        break;
                    }
                    case Road.Direction.Right:
                    {
                        _nextPosition += road.transform.right * road.Size;
                        break;
                    }
                    default:_nextPosition += road.transform.forward * road.Size; break;
                        
                }
                
                Debug.Log(_nextPosition.z);

                //road.transform.rotation = road.NextSpawnPoint.rotation;
                road.transform.localPosition = _nextPosition;
                road.transform.SetParent(RoadParent);
            }
        }
    }
}
