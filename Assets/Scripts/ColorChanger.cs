using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] float duration;

    private void Start()
    {
        int infinityLoopsParameter = -1;
        var material = GetComponent<MeshRenderer>().material;
        material.DOColor(Color.red, duration).SetLoops(infinityLoopsParameter, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
