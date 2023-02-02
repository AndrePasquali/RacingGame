using OcarinaStudios.MathRacing.Car.Fuel;
using OcarinaStudios.MathRacing.Extensions;
using OcarinaStudios.MathRacing.Game;
using OcarinaStudios.MathRacing.Service;
using OcarinaStudios.MathRacing.UI.Popup;
using UnityEngine;

namespace OcarinaStudios.MathRacing.UI
{
    public class UIManager: MonoBehaviour
    {
        [SerializeField] private GameObject _mathChallengePopup;
        private FuelManager _fuelManager;
        private GameManager _gameManager;

        private void InitializeServices()
        {
            _fuelManager = ServiceLocator.Get<FuelManager>();
            _gameManager = ServiceLocator.Get<GameManager>();

            _mathChallengePopup.GetComponent<MathPopup>().OnChallengeAnswerSubmit += OnChallengeSubmitResponse;
            
            _fuelManager.OnFuelEmpty += OnFuelEmpty;
        }

        private void Start() => InitializeServices();

        private void OnFuelEmpty()
        {
            return;
            PauseGame();
            ShowChallengePopup();
        }

        private void OnChallengeSubmitResponse(bool value)
        {
            return;
            if(value) OnCorrectAnswer();
        }

        private void ShowChallengePopup() => _mathChallengePopup.Show();

        private void HideChallengePopup() => _mathChallengePopup.Hide();

        private void OnCorrectAnswer()
        {
            _fuelManager.FillFuel();
            
            HideChallengePopup();
            UnPauseGame();
        }

        private void PauseGame()
        {
            _gameManager.Pause();
        }

        private void UnPauseGame()
        {
            _gameManager.Resume();
        }
    }
}