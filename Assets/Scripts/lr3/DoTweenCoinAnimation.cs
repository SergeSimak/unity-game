using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenCoinAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DOLocalMoveX(10, 10f);
    }
}
