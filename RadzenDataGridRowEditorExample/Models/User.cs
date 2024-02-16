namespace RadzenDataGridRowEditorExample.Models;

public record User
{
    public User(string Name, string Surname, int Age)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}
