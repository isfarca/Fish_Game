using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    [SerializeField] private Notice noticeScript = null;
    [SerializeField] private Fish fishScript = null;

    [SerializeField] private Text selectCountText = null;
    [SerializeField] private Button deleteSelectedFishs = null;
    [SerializeField] private Button[] fishButtons = null;

    private int selectCount;
    public string[] SelectedFishNames;

    [SerializeField] private GameObject selectionCanvas = null;

    [SerializeField] private GameObject endCanvas = null;
    [SerializeField] private GameObject end = null;

    private void Start()
    {
        deleteSelectedFishs.onClick.AddListener(OnDeleteSelectedFishs);

        fishButtons[0].onClick.AddListener(OnFish0Click);
        fishButtons[1].onClick.AddListener(OnFish1Click);
        fishButtons[2].onClick.AddListener(OnFish2Click);
        fishButtons[3].onClick.AddListener(OnFish3Click);
        fishButtons[4].onClick.AddListener(OnFish4Click);
        fishButtons[5].onClick.AddListener(OnFish5Click);
        fishButtons[6].onClick.AddListener(OnFish6Click);
    }

    private void OnEnable()
    {
        OnDeleteSelectedFishs();
        SelectedFishNames = new string[noticeScript.Images.Length];
    }

    private void OnFish0Click()
    {
        SelectFish(0);
    }
    private void OnFish1Click()
    {
        SelectFish(1);
    }
    private void OnFish2Click()
    {
        SelectFish(2);
    }
    private void OnFish3Click()
    {
        SelectFish(3);
    }
    private void OnFish4Click()
    {
        SelectFish(4);
    }
    private void OnFish5Click()
    {
        SelectFish(5);
    }
    private void OnFish6Click()
    {
        SelectFish(6);
    }

    private void SelectFish(int fishId)
    {
        SelectedFishNames[selectCount] = fishScript.Fishs[fishId].name;
        Debug.LogFormat("Selection: {0}", SelectedFishNames[selectCount]);
        selectCount++;
        selectCountText.text = selectCount.ToString();

        if (selectCount >= 4)
        {
            selectionCanvas.SetActive(false);
            gameObject.SetActive(false);

            endCanvas.SetActive(true);
            end.SetActive(true);
        }
    }

    private void OnDeleteSelectedFishs()
    {
        selectCount = 0;
        selectCountText.text = selectCount.ToString();
    }
}