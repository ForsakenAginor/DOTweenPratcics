using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Start()
    {
        int infinityLoopsParameter = -1;
        var material = GetComponent<MeshRenderer>().material;
        material.DOColor(Color.red, _duration).SetLoops(infinityLoopsParameter, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
