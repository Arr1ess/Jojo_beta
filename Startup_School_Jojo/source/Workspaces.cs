namespace DateBaseLogic
{
    public class Workspace
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Undefined";

        public string Guid_id {get; set;} = Guid.NewGuid().ToString();
        
        public List<int> Plugin_id { get; set; } = new List<int>();
        public string Settings { get; set; } = "";
        public Workspace()
        {
        }
        public Workspace(int id, string name = "Undefined")
        {
            Id = id;
            Name = name;
        }
    }
}