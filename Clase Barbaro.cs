using System;

public class Personagem
{
    public static void Main(string[] args)
    {
        Barbaro barb1 = new Barbaro();
        barb1.nome = "NomeBarbaro 1";
        barb1.Upar();
        barb1.Status();

        Barbaro barb2 = new Barbaro();
        barb2.nome = "NomeBarbaro 2";
        barb2.Upar();
        barb2.Status();

        Console.WriteLine("________________________________");
        barb1.Ataque(barb2);
        barb1.Status();
        barb2.Status();
        barb2.Revigorar();
        barb2.Status();
        barb2.Revigorar();
        barb2.Revigorar();
        barb2.Revigorar();
        barb2.Revigorar();
        barb2.Status();

    }
}    
public class Barbaro 
{
       public string nome = "Unknown";
       public int nivel = 1;
       public int vida = 30;
       public int energia = 10;
       public int maxVida = 34;
       public int maxEnergia = 10;
       public int vitalidade = 23;
       public int forca = 25;
       public int destreza = 15;
       public int inteligencia = 7;

       public void AtributosLimite()
       {
        if(vida > maxVida)
            {
                vida = maxVida;
            }
        if(energia > maxEnergia)
        {
                energia = maxEnergia;
        }
       }
       public void Revigorar()
       {
        int cura = (vida / 3) * 2;
        vida += cura;
        int curaenerg = (energia / 3);
        energia += energia;
        AtributosLimite();
        if(vida == maxVida)
        {
            cura = 0;
        }
        if(energia == maxEnergia)
        {
            curaenerg = 0;
        }
        Console.WriteLine($"O Barbaro {nome} usou uma pocao de cura! +{cura} de VIDA e +{curaenerg} de ENERGIA.");
       }
       public void Upar()
       {
        nivel++;
        forca += 5;
        vitalidade += 3;
        energia += 3;
        maxEnergia += 2;
        inteligencia += 1;
        destreza += 2;
        vida += 9;
        maxVida += (vitalidade / 3) * 2;
        Console.WriteLine($"O Barbaro {nome} upou de nivel!");
        AtributosLimite();
       }
       public void Status()
       {
        Console.WriteLine($"=====FICHA===== \nNome: {nome}\nNivel: {nivel}\nVitalidade: {vitalidade}\nForca: {forca}\nDestreza: {destreza}\nInteligencia: {inteligencia}\nVida Atual: {vida}\nVida Maxima: {maxVida}\nEnergia Atual: {energia}\nEnergia Maxima: {maxEnergia}");
       }
       public void Ataque(Barbaro BarbaroAlvo)
       {
        int dano = (forca / 2) + (destreza / 3) + (inteligencia / 5);
        if(energia <= 1)
        {
            Console.WriteLine($"O Atacante {nome} está sem ENERGIA disponível!");
        } else 
        {
            energia -= 2;
            BarbaroAlvo.vida -= dano;
            Console.WriteLine($"O Atacante {nome} infligiu {dano} de dano ao Alvo {BarbaroAlvo.nome}... 2 pontos de ENERGIA foram utilizados.");
        }
       }
}