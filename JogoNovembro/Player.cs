public delegate void Callback();
public class Player : JogoNovembro.Animacao
{
    public Player(Image a) : base(a)
    {
        for (int i = 1; i <= 37; ++i)
            Animacao1.Add($"anda{i.ToString("D2")}.png");
        for (int i = 2; i <= 2; ++i)
            Animacao1.Add($"playerdead{i.ToString("D2")}.png");
       SetAnimacaoAtiva(1);

    }
    public void Run()
    {
        loop = true;
        SetAnimacaoAtiva(1);
        Play();

    }
}