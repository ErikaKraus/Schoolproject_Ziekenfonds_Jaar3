namespace Groepsreizen_team_tet.ViewModels.GroepsreisViewModels
{
    public class GroepsreisIngeschrevenReizenViewModel
    {
        public List<KindReizenViewModel> KinderenReizen { get; set; } = new();
    }
    public class KindReizenViewModel
    {
        public int KindId { get; set; }
        public string KindNaam { get; set; } = default!;
        public string KindVoornaam { get; set; } = default!;
        public List<GroepsreisDetailViewModel> ToekomstigeReizen { get; set; } = new();
        public List<GroepsreisDetailViewModel> AfgelopenReizen { get; set; } = new();
    }
}

