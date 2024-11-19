namespace JogoNovembro;

using FFImageLoading.Maui;
public delegate void Callback();
public class Player : JogoNovembro.Animacao
{
    public Player(CachedImageView  a) : base(a)
    {
        for (int i = 1; i <= 30; ++i)
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
     public void MoveY (int s)
	{
		compImage.TranslationY += s;	
	}
	public double GetY ()
	{
		return compImage.TranslationY;
	}
	public void SetY (double a)
	{
		compImage.TranslationY = a;
	}
}