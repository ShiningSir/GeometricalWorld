using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    // singleton
    public static GameController instance;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}
