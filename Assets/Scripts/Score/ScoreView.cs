using TMPro;
using UnityEngine;

namespace Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreTMP;

        public void UpdateScore(int newScore) => scoreTMP.text = $"{newScore}";
    }
}