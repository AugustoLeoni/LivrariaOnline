namespace LivrariaOnline.Entities;

public class Book
{
    public virtual int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public float Price { get; set; }

    public int QtdStock { get; set; }
}
