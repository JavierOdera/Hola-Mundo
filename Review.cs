namespace MyApp;
public class Review
{
    int Calificacion;
    public string Comentario{set;get;}
    public Review(int calificacion, string comentario)
    {
        this.Calificacion=calificacion;
        this.Comentario=comentario;
    }
    public string GetInfo()
    {
        return $"{this.Comentario} calificacion:{this.Calificacion}";
    }
}