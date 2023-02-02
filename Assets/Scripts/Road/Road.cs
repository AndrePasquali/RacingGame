using System;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Road
{
    public class Road: MonoBehaviour
    {
        public enum Direction
        {
            Forward,
            Left,
            Right
        }

        private void Start()
        {
            Debug.Log(transform.forward.sqrMagnitude + " " + gameObject.name);
        }

        public Direction RoadDirection;

        public GameObject RoadPrefab => _roadPrefab ?? (_roadPrefab = GetComponent<GameObject>());
        private GameObject _roadPrefab;

        public float Size;

        public Transform NextSpawnPoint;
    }
}