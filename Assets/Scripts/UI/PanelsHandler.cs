using UnityEngine;

namespace UI
{
    public class PanelsHandler : MonoBehaviour
    {
        [SerializeField] private GameObject startPanel;
        [SerializeField] private GameObject endPanel;
        [SerializeField] private GameObject pausePanel;
        [SerializeField] private GameObject returnPanel;

        private void Awake()
        {
            InitUI();
        }

        private void InitUI()
        {
            startPanel.SetActive(true);
            endPanel.SetActive(false);
            pausePanel.SetActive(false);
            returnPanel.SetActive(false);
        }
    }
}
