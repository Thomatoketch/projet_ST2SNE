using UnityEngine;

public class WatchSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] watchModels;

    public void ChangeWatchModel(int index)
    {
        if (index < 0 || index >= watchModels.Length)
        {
            Debug.LogError("Index out of range for watch models.");
            return;
        }

        foreach (GameObject model in watchModels)
        {
            model.SetActive(false);
        }

        watchModels[index].SetActive(true);
    } 
}
