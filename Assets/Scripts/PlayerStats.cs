using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "PlayerStats", order =0)]
public class PlayerStats : ScriptableObject
{
   public int hp;
    [SerializeField] int maxhp;
    [SerializeField] int str;
    [SerializeField] int def;
    [SerializeField] float exp;

    public void ResetData(PlayerStats _newPlayerStats)
    {
        hp= _newPlayerStats.hp;
        maxhp= _newPlayerStats.maxhp;
        str= _newPlayerStats.str;
        def= _newPlayerStats.def;
        exp= _newPlayerStats.exp;
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("stats_hp",hp);
    }

    public void LoadData()
    {
        hp = PlayerPrefs.GetInt("stats_hp");
    }
}
