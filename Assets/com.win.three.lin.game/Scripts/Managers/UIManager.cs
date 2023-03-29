using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance 
    { 
        get => FindObjectOfType<UIManager>(); 
    }

    private int gameId;

    [SerializeField] GameObject menu;
    [SerializeField] GameObject records;
    [SerializeField] GameObject playmenu;

    [Space(10)]
    [SerializeField] Button playBtn;

    private void Awake()
    {
        playBtn.onClick.AddListener(() =>
        {
            Debug.Log(gameId);
        });

        GameSelector.OnGameSelected += (id) =>
        {
            gameId = id;
            playBtn.interactable = true;
        };
    }

    private void Start()
    {
        playBtn.interactable = false;
        OpenMenu();
    }

    public void OpenRecords()
    {
        menu.SetActive(false);
        records.SetActive(true);
    }

    public void OpenPlaymenu()
    {
        playmenu.SetActive(true);
        menu.SetActive(false);
    }

    public void OpenMenu()
    {
        records.SetActive(false);
        playmenu.SetActive(false);
        menu.SetActive(true);
    }
}
