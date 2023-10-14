

namespace DateBaseLogic{
    public class Plugin
    {
        public int Id {get; set;}
        public string Name {get;set;} = "";
        public List<int> Sample_id {get;set;} = new List<int>{};

        public Plugin(int id, int samples_id, string name = "Undefined"){
            Id = id;
            Name = name;
            Sample_id.Add(samples_id);
        }
    }
}