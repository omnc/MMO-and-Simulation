using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NetworkClientProcessing.Init(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
