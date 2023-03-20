using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //public static UIManager Instance { get => FindObjectOfType<UIManager>(); }

    //[SerializeField] GameObject loading;
    //[SerializeField] GameObject menu;
    //[SerializeField] GameObject game;
    //[SerializeField] GameObject rules;
    //[SerializeField] GameObject rating;
    //[SerializeField] GameObject country;
    //[SerializeField] GameObject pause;

    //[Space(10)]
    //[SerializeField] Text scoreText;
    //[SerializeField] Text levelText;

    //[Space(10)]
    //[SerializeField] Button chooseCountryBtn;
    //[SerializeField] Button rulesBtn;
    //[SerializeField] Button ratingBtn;

    //[Space(10)]
    //[SerializeField] HealthBar healthBar;

    //private void OnEnable()
    //{
    //    Enemy.OnBallGaught += OnBallGaughtEventHandler;
    //}

    //private void OnDestroy()
    //{
    //    Enemy.OnBallGaught -= OnBallGaughtEventHandler;
    //}

    //private void OnBallGaughtEventHandler(bool IsCaught)
    //{
    //    if (!IsCaught)
    //    {
    //        scoreText.text = $"{GameManager.score}";
    //    }

    //    levelText.text = $"{GameManager.level + 1}";
    //}

    //public static void ShowPopup(string status)
    //{
    //    Instantiate(Resources.Load<Popup>("popup"), GameObject.Find("main canvas").transform).Init(status);
    //}

    //private void Awake()
    //{
    //    scoreText.text = $"{GameManager.score}";
    //    levelText.text = $"{GameManager.level + 1}";

    //    Loading.OnLoadingStarted += () =>
    //    {
    //        menu.SetActive(false);
    //        game.SetActive(false);
    //        rules.SetActive(false);
    //        rating.SetActive(false);
    //        country.SetActive(false);
    //    };

    //    Loading.OnLoadingFinished += () =>
    //    {
    //        menu.SetActive(true);
    //    };

    //    chooseCountryBtn.onClick.AddListener(() =>
    //    {
    //        country.SetActive(true);
    //    });

    //    rulesBtn.onClick.AddListener(() =>
    //    {
    //        rules.SetActive(true);
    //    });

    //    ratingBtn.onClick.AddListener(() =>
    //    {
    //        rating.SetActive(true);
    //    });
    //}

    //private void Start()
    //{
    //    loading.SetActive(true);
    //}

    //public void OpenMenu()
    //{
    //    game.SetActive(false);
    //    menu.SetActive(true);
    //    pause.SetActive(false);

    //    GameManager.Instance.EndGame();
    //}

    //public void StartGameOnClick()
    //{
    //    menu.SetActive(false);
    //    game.SetActive(true);
    //    pause.SetActive(false);

    //    GameManager.Instance.StartGame();
    //    healthBar.ResetMe();

    //    scoreText.text = $"{GameManager.score}";
    //    levelText.text = $"{GameManager.level + 1}";
    //}

    //public void IsPauseGame(bool IsPause)
    //{
    //    GameManager.IsPause = IsPause;

    //    Time.timeScale = IsPause ? 0 : 1;
    //    pause.SetActive(IsPause);
    //}
}
