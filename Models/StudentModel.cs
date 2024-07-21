namespace OwnApp.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public string Standard { get; set; } = "";

        public int Age { get; set; }
        public int Mark { get; set; }

        public List<string> Skills { get; set; } = new List<string>(); // List of skills list is unlimited array 


    }
}
