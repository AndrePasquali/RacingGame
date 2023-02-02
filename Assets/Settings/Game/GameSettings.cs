using System;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Settings
{
    [CreateAssetMenu(order = 0, fileName = "GameSettings", menuName = "Settings/CreateGameSettings")]
    public class GameSettings: ScriptableObject
    {
        public CarSettings CarSettings;
    }
}