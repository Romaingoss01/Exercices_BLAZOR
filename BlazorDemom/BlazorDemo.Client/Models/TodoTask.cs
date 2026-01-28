namespace BlazorDemo.Client.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Titre { get; set; } = "";
        public bool EstTerminee { get; set; }
    }
}
