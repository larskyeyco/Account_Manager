using Account_Manager.DTO;
using Account_Manager.Services;
using Account_Manager.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Account_Manager
{
    public partial class MainWindow : Window
    {
        private readonly LeagueEntryService _leagueEntryService;
        private readonly SummonerService _summonerService;
        private RanksViewModel _viewModel = new RanksViewModel();
        private IMapper _mapper;
        public MainWindow(LeagueEntryService leagueEntryService, SummonerService summonerService)
        {
            InitializeComponent();

            DataContext = _viewModel;
            _leagueEntryService = leagueEntryService;
            _summonerService = summonerService;

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LeagueEntryDTO.AllRanks, AllRanksViewModel>();
                cfg.CreateMap<AllRanksViewModel, LeagueEntryDTO.AllRanks>();
            });
            _mapper = configuration.CreateMapper();
        }
        private void Button_Find_Click(object sender, RoutedEventArgs e)
        {
            string SummonerName;
            try
            {
                SummonerName = _summonerService.GetSummonerDTO(_viewModel.SummonerNameDTO).Id;
                _viewModel.Ranks = _mapper.Map<IEnumerable<AllRanksViewModel>>(_leagueEntryService.GetLeagueEntryDTO(SummonerName)).Where(x => x.QueueType == "RANKED_SOLO_5x5");
                _viewModel.SummonerUpdateDTO = _summonerService.GetSummonerDTO(_viewModel.SummonerNameDTO).RevisionDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Summoner Name - Data not found.");
            }
        }
    }
}
