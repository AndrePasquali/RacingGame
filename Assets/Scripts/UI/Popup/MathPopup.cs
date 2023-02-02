using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using OcarinaStudios.MathRacing.Math;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace OcarinaStudios.MathRacing.UI.Popup
{
    public class MathPopup : MonoBehaviour
    {
        [SerializeField] private TMP_Text _titleLabel;
        [SerializeField] private TMP_Text _questionLabel;
        [SerializeField] private TMP_InputField _anwserInput;
       
        public Action<bool> OnChallengeAnswerSubmit;
        
        private int _operationResult;

        private MathCalculator _calculator = new MathCalculator();

        private void Start()
        {
            _anwserInput.onValueChanged.AddListener(OnValueChanged);
            MathCalculator.OnResultObserver += OnResultReceived;
        }

        private void OnResultReceived(int operationResult)
        {
            Debug.Log($"CORRECT RESULT: {operationResult} ");
            _operationResult = operationResult;
        }

        private void OnValueChanged(string value)
        {
            var userInput = Int32.Parse(value);

            if(!string.IsNullOrEmpty(value)) OnValidateResult(userInput);
        }

        private void OnValidateResult(int userInput)
        {
            var correctAnswer = userInput == _operationResult;
            
            OnChallengeAnswerSubmit.Invoke(correctAnswer);
        }

        private void OnEnable()
        {
            GeneratedQuestion();
        }

        private async Task<bool> ValidateEnteredAnswer(int operationResult)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(1));
            return false;
        }

        private void GeneratedQuestion()
        {
            var numberX = Random.Range(1, 10);
            var numberY = Random.Range(1, 10);

            var operation = (MathOperationType)Random.Range(0, Enum.GetValues(typeof(MathOperationType)).Length - 2);

            switch (operation)
            {
                case MathOperationType.Divide:
                {
                    _calculator.Divide(numberX, numberY);
                    _questionLabel.text = $"{numberX} / {numberY} ?";
                    break;
                }
                case MathOperationType.Multiply:
                {
                    _calculator.Multiply(numberX, numberY);
                    _questionLabel.text = $"{numberX} * {numberY} ?";
                    break;
                }
                case MathOperationType.Subtract:
                {
                    _calculator.Subtract(numberX, numberY);
                    _questionLabel.text = $"{numberX} - {numberY} ?";
                    break;
                }
                case MathOperationType.Sum:
                {
                    _calculator.Sum(numberX, numberY);
                    _questionLabel.text = $"{numberX} + {numberY} ?";
                    break;
                }
            }
        }
    }
}
