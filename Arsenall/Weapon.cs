using System.Text.Json.Serialization;

public class Weapon
{
    [JsonInclude]
    public string Name;

    [JsonInclude]
    private int damageMax=20;

    [JsonInclude]
    private int damageMin=10;

     public int Attack()
    {
        return Random.Shared.Next(damageMin, damageMax);
    }
}
