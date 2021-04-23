using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

[CreateAssetMenu(fileName ="New FileScriptable", menuName ="File Data", order =51)]
public class FolderScriptable : ScriptableObject
{
    [SerializeField]
    private string fileName;

    [SerializeField]
    private string altText;

    [SerializeField]
    private int timesOpened;

    [SerializeField]
    private TextAsset inkJSONAsset = null;

    public string FileName
    {
        get
        {
            return fileName;
        }
    }

    public string AltText
    {
        get
        {
            return altText;
        }
    }
    public int TimesOpened
    {
        get
        {
            return timesOpened;
        }
    }

    public TextAsset InkJSONAsset
    {
        get
        {
            return inkJSONAsset;
        }
    }



}
