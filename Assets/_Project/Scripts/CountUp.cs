using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace _Project
{
    public class CountUp : MonoBehaviour
    {
        [SerializeField] private Button countUpButton;
        [SerializeField] private TextMeshProUGUI countUpText;
        private int _countValue = 0;

        private void Awake()
        {
            countUpText.text = _countValue.ToString();
        }

        private void Start()
        {
            countUpButton.OnClickAsObservable()
                .Subscribe(_ =>
                {
                    _countValue++;
                    countUpText.text = _countValue.ToString();
                }).AddTo(this);
        }
    }
}