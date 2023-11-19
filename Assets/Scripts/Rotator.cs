using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float duration;

    private void Start()
    {
        int infinityLoopsParameter = -1;
        int halfModifier = 2;
        Vector3 piRotate = new Vector3(0, 180, 0);
        transform.DORotate(transform.eulerAngles + piRotate, duration / halfModifier).SetLoops(infinityLoopsParameter, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
