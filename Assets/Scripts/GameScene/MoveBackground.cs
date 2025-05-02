using System.Collections;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _offsetPosition;

    private Vector3 _moveDirection;
    private Vector3 _firstStartPosition;
    private Vector3 _secondStartPosition;

    private GameObject _firstFrame;
    private GameObject _secondFrame;

    private void Start()
    {
        _firstFrame = transform.GetChild(0).gameObject;
        _secondFrame = transform.GetChild(1).gameObject;

        _moveDirection = new Vector3(-1, 0, 0);
        _firstStartPosition = _firstFrame.transform.position;
        _secondStartPosition = _secondFrame.transform.position;
        _offsetPosition = 2 * _firstStartPosition.x - _secondStartPosition.x;

        StartCoroutine(MoveFramesCoroutine());
    }


    private IEnumerator MoveFramesCoroutine()
    {
        while (true)
        {
            MoveFrame(_firstFrame);
            MoveFrame(_secondFrame);

            yield return null;
        }
    }

    private void MoveFrame(GameObject frame)
    {
        var step = _moveDirection * _speed * Time.deltaTime;
        var firstPosition = frame.transform.position;

        if (firstPosition.x + step.x <= _offsetPosition)
        {
            frame.transform.position = _secondStartPosition + step;
        }
        else
        {
            frame.transform.position += step;
        }
    }
}
