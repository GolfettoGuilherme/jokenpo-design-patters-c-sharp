# Jogo Jo-Ken-Po C#
um Jogo de Pedra, Papel, Tesoura, Largarto Spock implementado em C# seguindo boas práticas de programação


##Quais boas práticas estamos falando?

Bom, eu usei nele principios de Coesão e Singleton e orientação a objetos.

##Massa, mas como eu faço para rodar?

Simples bro, abra a solution no Visual Studio e mande executar.

##Tentei rodar o projeto e não deu certo,e agora?

Caso tenha alguma dúvida, você pode mandar um e-mail para `golfetto.guilherme@gmail.com` com sua dúvida que eu vou tentar te ajudar.

##Me explica esse projeto ai rapaz?

Calma amigo, então: Todas as possiveis escolhas herdam da classe Escolha (dãh).

todas tem uma instancia delas mesmo para servirem como chamada própria e todas tem uma Lista das outras escolhas que elas ganham.

por exemplo:

```
public class Papel : Escolha
{
    private static Papel Instancia = null; //Ela mesma

    public Papel()
    {
        if (!FoiConfigurada)
        {
            FoiConfigurada = true;
            Iniciar();
        }
    }

    public override void Iniciar()
    {
        //Adiciono a Instancia da classes para evitar Stackoverflow e usar conceitos de Singleton
        this.Ganha.Add(Pedra.BuscarInstancia());
        this.Ganha.Add(Spock.BuscarInstancia());
    }

    //infelizmente esse método eu não consegui deixa-lo na classe abstrata Escolha porquê ele é estático
    public static Papel BuscarInstancia()
    {
        if (Instancia == null)
            Instancia = new Papel();

        return Instancia;
    }
}
```

Como podemos ver, não ficou perfeito, porquê o método BuscarInstancia ainda precisa ser implementado manualmente sempre que uma nova Escolha for criada. Infelizmente não consegui encontrar uma forma melhor de resolver isso (por enquanto).

:)


