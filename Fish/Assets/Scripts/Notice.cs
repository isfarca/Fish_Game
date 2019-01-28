using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Notice : MonoBehaviour
{
    [SerializeField] private Fish fishScript = null;

    public Image[] Images = null;

    [SerializeField] private Text secondsText = null;

    [SerializeField] private GameObject noticeCanvas = null;

    [SerializeField] private GameObject selectionCanvas = null;
    [SerializeField] private GameObject selection = null;

    private void OnEnable()
    {
        for (int i = 0; i < Images.Length; i++)
        {
            Images[i].sprite = fishScript.Fishs[Random.Range(0, fishScript.Fishs.Length - 1)];
            Debug.LogFormat("Notice: {0}", Images[i].sprite.name);
        }

        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        secondsText.text = "3";
        yield return new WaitForSeconds(1);

        secondsText.text = "2";
        yield return new WaitForSeconds(1);

        secondsText.text = "1";
        yield return new WaitForSeconds(1);

        secondsText.text = "0";

        noticeCanvas.SetActive(false);
        gameObject.SetActive(false);

        selectionCanvas.SetActive(true);
        selection.SetActive(true);

        StopCoroutine(Countdown());
    }
}