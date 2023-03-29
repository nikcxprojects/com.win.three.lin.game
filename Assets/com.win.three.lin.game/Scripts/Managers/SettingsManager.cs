using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [Space(10)]
    [SerializeField] AudioSource loop;
    [SerializeField] Button soundBtn;

    [Space(10)]
    [SerializeField] AudioSource sfx;
    [SerializeField] Button sfxBtn;

    [Space(10)]
    [SerializeField] Button vibroBtn;

    [Space(10)]
    [SerializeField] Color active;
    [SerializeField] Color disable;

    public static bool VibraEnable { get; set; } = true;

    private void Start()
    {
        loop.mute = sfx.mute = true;

        soundBtn.onClick.AddListener(() =>
        {
            loop.mute = !loop.mute;

            var soundImg = soundBtn.GetComponent<Image>();
            var handleImg = soundBtn.transform.GetChild(0).GetComponent<Image>();

            soundImg.color = loop.mute ? disable : active;
            handleImg.color = loop.mute ? active : disable;
        });


        sfxBtn.onClick.AddListener(() =>
        {
            sfx.mute = !sfx.mute;

            var sfxImg = sfxBtn.GetComponent<Image>();
            var handleImg = sfxBtn.transform.GetChild(0).GetComponent<Image>();

            sfxImg.color = sfx.mute ? disable : active;
            handleImg.color = sfx.mute ? active : disable;
        });

        vibroBtn.onClick.AddListener(() =>
        {
            VibraEnable = !VibraEnable;

            var vibraImg = vibroBtn.GetComponent<Image>();
            var handleImg = vibroBtn.transform.GetChild(0).GetComponent<Image>();

            vibraImg.color = VibraEnable ? disable : active;
            handleImg.color = VibraEnable ? active : disable;
        });

        soundBtn.onClick.Invoke();
        sfxBtn.onClick.Invoke();
        vibroBtn.onClick.Invoke();
    }
}
