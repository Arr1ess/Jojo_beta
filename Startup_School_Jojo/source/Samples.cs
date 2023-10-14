


namespace DateBaseLogic{
    public class Sample
    {
        public int Id {get; set;}
        public string Name {get;set;} = "";
        public string Settings {get;set;} = "";

        public Sample(int id, string name = "Defolt", string settings = "Defolt"){
            Name = name;
            Settings = settings;
            Id = id;
            // Создание элемента в базе данных
        }
    }
}