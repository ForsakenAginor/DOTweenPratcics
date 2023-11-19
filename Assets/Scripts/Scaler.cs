using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] float duration;

    private void Start()
    {
        int infinityLoopsParameter = -1;
        Vector3 maxScaleValues = new Vector3(2, 2, 2);
        transform.DOScale(maxScaleValues, duration).SetLoops(infinityLoopsParameter, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
