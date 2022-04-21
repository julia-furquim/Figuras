public class Retangulo
{
//Propriedades
    public double Largura{ get; set; }
    public double Comprimento { get; set; }
    

    //Atributo em maiusculo
    public double Area {
     get { return Largura * Comprimento; }
    }
    public double Perimetro{get => ((Largura * 2) + (Comprimento * 2));}
    public Retangulo(double largura, double comprimento)
    {
        Largura = largura;
        Comprimento = comprimento;

    } //=> Largura = largura;


    //public Retangulo(double comprimento) => Comprimento = comprimento;



}
