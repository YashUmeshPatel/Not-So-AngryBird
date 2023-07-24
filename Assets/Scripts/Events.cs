using UnityEngine;

public class Events : MonoBehaviour
{
    public delegate void AddScoreEvent();
    public static event AddScoreEvent OnAddScore;
}
