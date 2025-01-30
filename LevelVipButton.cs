using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelVipButton : MonoBehaviour
{
    [Header("Active Stuff")]
    public bool isActive;
    public Sprite activeSprite;
    public Sprite lockedSprite;
    private Image buttonImage;
    private Button myButton;
    private int starsActive;
    private int levelActive;

    [Header("Level UI")]
    public Image[] stars;

    public Text levelText;
    public int level;


    private LevelButton levelButton;
    private GameData gameData;
    private Board board;
    static LevelVipButton instance;
    public static LevelVipButton Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(LevelVipButton)) as LevelVipButton;

            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Instance = this;
        gameData = FindObjectOfType<GameData>();
        buttonImage = GetComponent<Image>();
        myButton = GetComponent<Button>();
        LoadData();
        //ActivateStars();
        //DecidedButton();
        //BlockButton();
    }
    void LoadData()
    {
        //Is GameData present?
        if (gameData != null)
        {
            //Decide if the level is active
            if (gameData.saveData.isActive[level - 1])
            {
                isActive = true;
            }
            else
            {
                isActive = false;
            }
            //Decide how many stars to activate
            starsActive = gameData.saveData.stars[level - 1];
        }
    }
    public void DecidedButton()
    {
        if (isActive)
        {
           
            //activeSprite.SetActive(true);
            //lockedSprite.SetActive(false);
           
            buttonImage.sprite = activeSprite;
            myButton.enabled = true;
            levelText.enabled = true;
            //if(gameData != null)
            //{
            //    gameData.saveData.isActive[board.level - 3] = true;
            //    gameData.Save();
            //}
           
            //gameData.Save();
        }
       
        else
        {
            buttonImage.sprite = lockedSprite;
            myButton.enabled = false;
            levelText.enabled = false;
        }
        //PlayerPrefs.SetInt("openBtn", 1);
        //UIInfo.Instance.UpdateOpenButton();
        //Debug.Log("Purchase: vipcontent");


        //gameData.Save();
        //if (isActive)
        //{
        //    buttonImage.sprite = activeSprite;
        //    myButton.enabled = true;
        //    levelText.enabled = true;
        //}
        //buttonImage.sprite = activeSprite;
        //myButton.enabled = true;
        //levelText.enabled = true;

        //buttonImage.sprite = lockedSprite;
        //myButton.enabled = false;
        //levelText.enabled = false;
    }
    void BlockButton()
    {
        //if()
        buttonImage.sprite = lockedSprite;
        myButton.enabled = false;
        levelText.enabled = false;
    }
    // Update is called once per frame
    //public void LevelButtonUpdate()
    //{
    //    if (DecidedButton != null)
    //    {

    //    }    
    //}
    void Update()
    {
        
    }
}
