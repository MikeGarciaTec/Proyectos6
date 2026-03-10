using System.Globalization;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;
    bool isOnPause=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.GetInstance().OnGameStateChange += OnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.GetInstance().OnGameStateChange -= OnGameStateChanged;
    }

    void OnGameStateChanged(GAME_STATES _newGameState)
    {
        isOnPause = _newGameState != GAME_STATES.GAMEPLAY;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.GetInstance().ChangeGameState(isOnPause? GAME_STATES.GAMEPLAY: GAME_STATES.PAUSE);
        }

        if (!isOnPause)
        {
            transform.Translate(transform.forward * Time.deltaTime * speed);
        }
    }
}
