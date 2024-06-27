using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.CheckSaveFile();
        levelCurrent = GameManager.Instance.levelCurrent;
        AddChangeSceneListeners();
        DisableLockedLevel();
    }

    [Header("Level Selection Buttons")]
    public int levelCurrent;
    public Button[] levelButtons;

    public int sceneIndex;
    private void AddChangeSceneListeners()
    {
        for(int i = 0; i < levelButtons.Length; i++)
        {
            int sceneIndex = i + 1;
            levelButtons[i].onClick.AddListener(() => GameManager.Instance.ChangeScene(sceneIndex));
        }
    }

    private void DisableLockedLevel()
    {
        for(int i = 0;i < levelButtons.Length;i++)
        {
            if(i > levelCurrent)
            {
                levelButtons[i].interactable = false;
            }
        }
    }
}
