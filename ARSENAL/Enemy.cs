using System.Text.Json.Serialization;

public class Enemy
{
    
    [JsonInclude]
    public int Hp;

    [JsonInclude]
    public string Name;
}