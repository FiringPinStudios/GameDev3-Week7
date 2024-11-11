using UnityEngine;
using TMPro;

namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;

        public void UpdateScoreText()
        {
            scoreText.text = $"<b>Score</b>:{GameManager.Instance.Score}";
        }
    }
}
