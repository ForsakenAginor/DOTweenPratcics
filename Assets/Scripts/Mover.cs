using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Start()
    {
        int infinityLoopsParameter = -1;
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = currentPosition;
        targetPosition.x *= -1;
        transform.DOMove(targetPosition, _duration).SetLoops(infinityLoopsParameter, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
