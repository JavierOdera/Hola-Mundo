//Debo hacer una clase producto y una clase review. La clase review debe ser uno de los atributos de la clase producto. El producto debe tener nombre, precio y una lista de reviews.
//las reviews deben tener calificacion(de 1 a 5) y comentarios. La clase producto debe tener una fucion para agregar reviews a cada producto

namespace MyApp;
using System.Collections.Generic;

public class Producto
{
    private string Nombre;
    private int Precio;
    private List<Review> Lista_de_Reviews;

    public string getInfo()
    {
        string strret= $"{this.Nombre} cuesta {this.Precio} y tiene las siguientes reviews: ";
        foreach (Review review in this.Lista_de_Reviews)
        {
            strret=strret+review.GetInfo();
            
        }
        return strret;
    }
    
    
    public Producto(string Nombre, int Precio)
    {
        this.Nombre=Nombre;
        this.Precio=Precio;
        this.Lista_de_Reviews= new List<Review>();
    }
    public void Agrev(Review review )
    {
        this.Lista_de_Reviews.Add(review);
    }

}