using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Start()
    {
        int infinityLoopsParameter = -1;
        int halfModifier = 2;
        Vector3 piRotate = new Vector3(0, 180, 0);
        transform.DORotate(transform.eulerAngles + piRotate, _duration / halfModifier).SetLoops(infinityLoopsParameter, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
