using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GameDataParser.Model;
using GameDataParser.UserInteraction;

namespace GameDataParser.DataAccess
{
    internal class VideoGamesDeserializer : IVideoGamesDeserializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGamesDeserializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeserializeFrom(string fileName, string fileContents)
        {

            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"JSON in {fileName} file was not in a valid format. JSON body:");
                _userInteractor.PrintError(fileContents);

                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            }
        }
    }
}
