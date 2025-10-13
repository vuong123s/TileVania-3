using UnityEngine;

public class GameSession : MonoBehaviour
{
    void Awake()
    {
        // create our Singleton
        int numberGameSessions = FindObjectsByType<GameSession>(FindObjectsSortMode.None).Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // when player dies, do certain things
    // reduce number of lives
    // if we have no lives left then restart the whole game



    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
