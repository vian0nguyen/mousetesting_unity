using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;

public class InkHandler : MonoBehaviour
{
    //public static event Action<Story> OnCreateStory; //is action deprecated?
    void Awake()
    {
        // Remove the default message
        RemoveChildren();
    }

    public void Begin()
    {
        Debug.Log("1-800-are we startin");
        RemoveChildren();
        StartStory();
        storyBegin = true;
    }

    // Creates a new Story object with the compiled story which we can then play!
    public void StartStory()
    {
        story = new Story(inkJSONAsset.text);
        // if (OnCreateStory != null) OnCreateStory(story);
        RefreshView();
    }
    public void RefreshView()
    {
        // Remove all the UI on screen
        RemoveChildren();


        //Debug.Log("u can start :thumbs up:");
        // Read all the content until we can't continue any more
        if (story.canContinue)
        {
            //textBoxQ.enabled = true;
            //textBoxClay.enabled = true;
            // Continue gets the next line of the story
            currentText = story.Continue();

            // This removes any white space from the text.
            currentText = currentText.Trim();
            // Display the text on screen!
            CreateContentView(currentText);

        }

        // Display all the choices, if there are any!
        if (story.currentChoices.Count > 0)
        {
            for (int i = 0; i < story.currentChoices.Count; i++)
            {
                Choice choice = story.currentChoices[i];
                Button button = CreateChoiceView(choice.text.Trim());
                button.onClick.AddListener(delegate //uhOH un poggers..all this is being handled by SenderOnDrag..
                    {
                        OnClickChoiceButton(choice);
                    });
            }
        }
        // If we've read all the content and there's no choices, the story is finished!
        else
        {
            //commented out from skaterfools, lets see if the game starts
            Button choice = CreateChoiceView("End of story.\nRestart?");
            choice.onClick.AddListener(delegate
            {
                StartStory();
                Debug.Log("story start!");
            });

            RemoveChildren();
        }

    }
    // When we click the choice button, tell the story to choose that choice!
    void OnClickChoiceButton(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        RefreshView();
    }

    // Creates a textbox showing the the line of text       //connect all strings into one game object instead of cloning multiple game objects!
    void CreateContentView(string text)
    {
        //test
        TMP_Text storyText = Instantiate(textPrefab) as TMP_Text;
        storyText.text = text;
        storyText.transform.SetParent(canvas.transform, false);


        //if we were lookign for tags, whcih we're not doing now
        /*List<string> tags = story.currentTags;

         if (tags.Count > 0)
        {
             if (tags.Contains("q"))
             {
                 textBoxSender.text = text;
                 textBoxReciever.text = "";
             }
             else if (tags.Contains("clay"))
             {
                 textBoxSender.text = text;
                 textBoxReciever.text = "";//blank strings so they dont interrupt each other
             }
    }
        else
        {

            textBoxReciever.text = text; //assume tagless text is q
        }*/

    }

    // Creates a button showing the choice text
    Button CreateChoiceView(string text)
      {
          // Creates the button from a prefab
          Button choice = Instantiate(buttonPrefab) as Button;
          choice.transform.SetParent(canvas.transform,false);

          // Gets the text from the button prefab
          //Text choiceText = choice.GetComponentInChildren<Text>();  //for unity ui
          TMP_Text choiceText = choice.GetComponentInChildren<TMP_Text>();    //for tmp
          choiceText.text = text;

          // Make the button expand to fit the text
          HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
          layoutGroup.childForceExpandHeight = false;//changed to true
          //ISSUE: NEEDS THIS TO print many choices... but prints dialog weirD
          return choice;
      }


    public void RemoveChildren()
    {
        int childCount = canvas.transform.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            //instead of destroy -> set button interactable to false
            // GameObject.Destroy(canvas.transform.GetChild(i).gameObject);
            //(canvas.transform.GetChild(i)).interactable = false; //how to use this child count?
            buttonPrefab.interactable = false;
        }


    }

    [SerializeField]
    public TextAsset inkJSONAsset = null;
    public Story story;

    public bool storyBegin;
    public string currentText;

   // public TMP_Text textBoxSender=null;
   // public TMP_Text textBoxReciever =null; // if we used tags we'd use this


    [SerializeField]
    private Canvas canvas = null;

    // UI Prefabs
     [SerializeField]
    //private Text textPrefab = null;
    private TMP_Text textPrefab = null;

    [SerializeField]
    private Button buttonPrefab = null;

}
