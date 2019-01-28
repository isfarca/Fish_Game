using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    [SerializeField] private Notice noticeScript = null;
    [SerializeField] private Choice choiceScript = null;

    [SerializeField] private Text resultText = null;
    [SerializeField] private Button againButton = null;

    [SerializeField] private GameObject endCanvas = null;

    [SerializeField] private GameObject noticeCanvas = null;
    [SerializeField] private GameObject notice = null;

    private void Start()
    {
        againButton.onClick.AddListener(OnAgainClick);
    }

    private void OnEnable()
    {
        bool isCorrect = true;

        for (int i = 0; i < noticeScript.Images.Length; i++)
        {
            Debug.LogFormat("Notice: {0} == Selected: {1}", noticeScript.Images[i].sprite.name, 
                choiceScript.SelectedFishNames[i]);

            if (noticeScript.Images[i].sprite.name != choiceScript.SelectedFishNames[i])
            {
                isCorrect = false;
                break;
            }
        }

        if (isCorrect)
        {
            resultText.text = "Richtig!";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "Falsch!";
            resultText.color = Color.red;
        }
    }

    private void OnAgainClick()
    {
        endCanvas.SetActive(false);
        gameObject.SetActive(false);

        noticeCanvas.SetActive(true);
        notice.SetActive(true);
    }
}