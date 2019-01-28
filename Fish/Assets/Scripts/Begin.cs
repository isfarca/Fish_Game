using UnityEngine;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    [SerializeField] private Button startButton = null;

    [SerializeField] private GameObject startCanvas = null;

    [SerializeField] private GameObject noticeCanvas = null;
    [SerializeField] private GameObject notice = null;

    private void Start()
    {
        startButton.onClick.AddListener(OnStartClick);
    }

    private void OnStartClick()
    {
        startCanvas.SetActive(false);

        noticeCanvas.SetActive(true);
        notice.SetActive(true);
    }
}