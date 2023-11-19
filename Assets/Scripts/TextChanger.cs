using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float duration;

    private void Start()
    {
        float doubleDuration = duration * 2;
        _text.DOText("Hello World!", duration);
        _text.DOText(" And Goodbye!", duration).SetRelative().SetDelay(duration);
        _text.DOText("Apocalypse NOW!", duration, true, ScrambleMode.All).SetDelay(doubleDuration);
    }
}
