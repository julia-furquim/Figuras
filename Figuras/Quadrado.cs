public class Quadrado
{
//Propriedades
    public double Lado { get; set; }

    //Atributo em maiusculo
    public double Area {
     get { return Lado * Lado; }
    }
    public double Perimetro{get => 4 * Lado;}
    public Quadrado(double lado) => Lado = lado;

}

