using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPauseMenu : MonoBehaviour
{
    [SerializeField] private PauseMenu _pauseMenu;

    private void Start()
    {
        _pauseMenu.Subscribe();
    }
}
