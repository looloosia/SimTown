using UnityEngine;

public class Sim : MonoBehaviour
{
    private int power;
    
    private int mercy;
    private int ambition;
    private int cunning;
    private int boldness;
    private int lust;

    private int hunger;
    private int content;
    private int sleep;

    void Awake()
    {
        Initialize();
    }
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    void Initialize()
    {
        
    }

    void ChangeValue(Constants.Values value, int amount)
    {
        switch (value)
        {
            case (Constants.Values.Power):
                power += amount;
                break;
        }
    }

    void OnClick()
    {
        
    }
}
