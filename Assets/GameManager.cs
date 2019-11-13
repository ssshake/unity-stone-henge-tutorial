using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    public int GatesCompleted = 0;
    public List<GameObject> Gates;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void WentThroughGate()
    {
        GatesCompleted++;
        if (GatesCompleted >= Gates.Count)
        {
            Debug.Log("Game Over");
        }
    }


}


public class SingletonDontDestroyOnLoad : MonoBehaviour
{

    private static SingletonDontDestroyOnLoad _instance;
    public static SingletonDontDestroyOnLoad Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}