using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class File : MonoBehaviour
{
    [SerializeField]
    private FolderScriptable fileData; // 1

    public TMP_Text text;
    public TMP_Text altText;

    public int timesOpened;

    private void Start()
    {
        text = GetComponentInChildren<TMP_Text>();
        text.text = fileData.FileName;


    }

    private void OnMouseDown() // 2
    {
        Debug.Log(fileData.FileName); // 3
        Debug.Log(fileData.AltText); // 3
        Debug.Log(fileData.TimesOpened); // 3
        Debug.Log(fileData.InkJSONAsset.name); // 3
    }

}
