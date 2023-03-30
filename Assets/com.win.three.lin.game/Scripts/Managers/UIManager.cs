using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance 
    { 
        get => FindObjectOfType<UIManager>(); 
    }

    private int gameId;
    private GameObject _gameRef;

    [SerializeField] GameObject menu;
    [SerializeField] GameObject records;
    [SerializeField] GameObject playmenu;
    [SerializeField] GameObject bottom;
    [SerializeField] GameObject game;

    [Space(10)]
    [SerializeField] Button playBtn;

    private void Awake()
    {
        playBtn.onClick.AddListener(() =>
        {
            var _parent = GameObject.Find("Environment").transform;
            var _prefab = gameId switch
            {
                0 => Resources.Load<GameObject>("HockeyGame"),
                1 => Resources.Load<GameObject>("CatchGame"),
                2 => Resources.Load<GameObject>("PenaltyGame"),
            };

            _gameRef = Instantiate(_prefab, _parent);

            playmenu.SetActive(false);
            bottom.SetActive(false);

            game.SetActive(true);
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
        if(_gameRef)
        {
            Destroy(_gameRef);
        }

        records.SetActive(false);
        playmenu.SetActive(false);
        game.SetActive(false);

        bottom.SetActive(true);
        menu.SetActive(true);
    }
}
