using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObstacle : MonoBehaviour
{
    [SerializeField] private string filterTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!string.IsNullOrEmpty(filterTag) && !other.CompareTag(filterTag))
            return;

        other.gameObject.SetActive(false);
    }
}
