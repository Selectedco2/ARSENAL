using System.Text.Json.Serialization;

public class Warstaff
{
    [JsonInclude]
    public string name;

    [JsonInclude]
    private int damageMin = 10;

    [JsonInclude]
    private int damageMax = 30;

    public int Meteor()
    {
        return Random.Shared.Next(damageMin, damageMax);
    }
}