using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class GameSelector : MonoBehaviour
{
    public static Action<int> OnGameSelected { get; set; }

    private void Start()
    {
        foreach(Transform t in transform)
        {
            var btn = t.GetComponent<Button>();
            btn.onClick.AddListener(() =>
            {
                var selected = EventSystem.current.currentSelectedGameObject;
                foreach(Transform _t in transform)
                {
                    var dot = _t.GetChild(1).gameObject;
                    dot.SetActive(selected.transform.GetSiblingIndex() == _t.GetSiblingIndex());

                    OnGameSelected?.Invoke(selected.transform.GetSiblingIndex());
                }
            });
        }
    }
}
