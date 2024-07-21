namespace OwnApp.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public int Marks { get; set; }
        public DateTime DateOfBirth { get; set; } // Student's date of birth
        public List<string> Skills { get; set; } = new List<string>(); // List of skills


    }
}
