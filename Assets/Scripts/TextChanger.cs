using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        int stage = 2;
        _text.DOText("Hello World!", _duration);
        _text.DOText(" And Goodbye!", _duration).SetRelative().SetDelay(_duration);
        _text.DOText("Apocalypse NOW!", _duration, true, ScrambleMode.All).SetDelay(_duration * stage);
    }
}
