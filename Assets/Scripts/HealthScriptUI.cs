using UnityEngine.UI;
using UnityEngine;

public class HealthScriptUI : MonoBehaviour
{
    public static int currentHearts;
    public int oldHearts;

    public Sprite[] heartTypes;
    public Image[] heartSlots;

    // Start is called before the first frame update
    void Start()
    {
        currentHearts = 5;
        oldHearts = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (oldHearts != currentHearts)
        {
            oldHearts = currentHearts;
            HeartUIUpdate();
        }
    }

    void HeartUIUpdate()
    {
        
    }

}
