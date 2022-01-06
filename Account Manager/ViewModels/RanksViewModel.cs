using System.Collections.Generic;
using System.ComponentModel;

namespace Account_Manager.ViewModels
{
    public class RanksViewModel : INotifyPropertyChanged
    {
        public long? SummonerUpdateDTO { get; set; }
        public string SummonerNameDTO { get; set; }
        public IEnumerable<AllRanksViewModel> Ranks { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
