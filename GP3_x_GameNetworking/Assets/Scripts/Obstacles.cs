using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacles : MonoBehaviour
{
    public Vector3 Spinning;
    public float Duration;
    public int loopCount;
    public LoopType loop;

    public Vector3 startPosition;
    public Vector3 endPosition;
    public float LRDuration;

    public GameManager gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalRotate(Spinning, Duration, RotateMode.LocalAxisAdd).SetLoops(loopCount, loop).SetEase(Ease.Linear);

        StartMovement();
    }

    public void StartMovement()
    {
        transform.DOLocalMove(endPosition, LRDuration).OnComplete(() => RestartMovement()).SetEase(Ease.Linear);
    }

    public void RestartMovement()
    {
        transform.DOLocalMove(startPosition, LRDuration).OnComplete(() => StartMovement()).SetEase(Ease.Linear);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Obstacles>() != null)
        {
            Destroy(gameObject);
            return;
        }

        if (col.CompareTag("Player"))
        {
            Time.timeScale = 0;
            //Add SetActive GameOverUI
        }
    }
}
