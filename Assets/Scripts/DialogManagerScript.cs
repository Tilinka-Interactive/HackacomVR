using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogManagerScript : MonoBehaviour
{
    [SerializeField]private string[] dialogList = new string[30];
    [SerializeField] private TextMeshProUGUI dialogT;
    [SerializeField] private Button nextButton;

    public int actualD = 1;
    void Start()
    {
        dialogT.text = dialogList[0];
    }

    public void NextDialog() {
        if (actualD + 1 < dialogList.Length)
        {
            actualD += 1;
            dialogT.text = dialogList[actualD];
        }
        else nextButton.gameObject.SetActive(false);
    }
}