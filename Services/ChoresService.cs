namespace csharpthing.Services;

public class ChoresService
{

    private readonly ChoresRepository _choresRepository;

    public ChoresService(ChoresRepository choresRepository)
    {
        _choresRepository = choresRepository;
    }


    public List<Chore> GetChores()
    {
        List<Chore> chores = _choresRepository.GetChores();
        return chores;
    }
}

