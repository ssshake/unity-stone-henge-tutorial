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

    private void Start()
    {
        Gates.ForEach(delegate (GameObject gate)
        {
            gate.SetActive(false);
        });
        EnableNextGate();
    }

    public void WentThroughGate()
    {
        GatesCompleted++;
        if (GatesCompleted >= Gates.Count)
        {
            Debug.Log("Game Over");
        }
        else {
            EnableNextGate();
        }
        
    }

    void EnableNextGate() {
        Gates[GatesCompleted].SetActive(true);
    }


}