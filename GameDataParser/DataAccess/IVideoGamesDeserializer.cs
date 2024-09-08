using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    internal interface IVideoGamesDeserializer
    {
        List<VideoGame> DeserializeFrom(string fileName, string fileContents);
    }
}