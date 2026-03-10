using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    [SerializeField] PlayerStats baseStats;
    [SerializeField] PlayerStats playerStats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStats.ResetData(baseStats);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerStats.SaveData();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            playerStats.LoadData();
        }
    }
}
