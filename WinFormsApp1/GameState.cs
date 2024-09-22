using Newtonsoft.Json;
using System.Linq;
using System.Xml;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp1
{
    
    internal class GameState
    {
        private readonly string directory = @"c:\\temp\\tower";
        private string fileName => $"{directory}\\stats.json";
        private string fileNameHistory => $"{directory}\\stats{DateTime.Now.ToString("yyyy-MM-dd-HH:mm")}.json";

        public List<ClickableComponent> Components { get; }

        public GameState(List<ClickableComponent> components)
        {
            Components = components;
        }

        public void Save()
        {
            var list = Components.Select(c => c.GetData());

            string contents = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileName, contents);
        }

        public void Save(StateDTO state)
        {
            string contents = JsonConvert.SerializeObject(state, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileName, contents);
        }

        public void Load()
        {
            string contents = File.ReadAllText(fileName);
            var stateDTO = JsonConvert.DeserializeObject<List<ComponentDto>>(contents);
            
            Components.ForEach(c =>
            {
                var componentstateDto = stateDTO.SingleOrDefault(s => s.Title == c.Title);
                if (componentstateDto != null)
                {
                    c.LoadData(componentstateDto);
                }
            });
        }
    }
}
