using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTracker : MonoBehaviour
{
    public int goal = 5;
    public int goalTracker = 0;
    public Text goalText;

    // Update is called once per frame
    void Update()
    {
        if (goalTracker < goal)
            goalText.text = "Objective:\nPaint your frustrations!\t" + goalTracker + " / " + goal;
        if (goalTracker >= goal)
            goalText.text = "Objective:\nEscape the area!\nGo back to the start!";
    }
}
