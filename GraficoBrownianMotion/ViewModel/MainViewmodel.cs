	using System;
using System.Windows.Input;
using GraficoBrownianMotion.Model.BrownianMotionApp.Model;

namespace GraficoBrownianMotion.ViewModel
{
    public class MainViewModel : BindableObject
    {
        private double _initialPrice;
        private double _volatility;
        private double _meanReturn;
        private int _numDays;
        private double[] _prices;

        public double InitialPrice
        {
            get => _initialPrice;
            set { _initialPrice = value; OnPropertyChanged(); }
        }

        public double Volatility
        {
            get => _volatility;
            set { _volatility = value; OnPropertyChanged(); }
        }

        public double MeanReturn
        {
            get => _meanReturn;
            set { _meanReturn = value; OnPropertyChanged(); }
        }

        public int NumDays
        {
            get => _numDays;
            set { _numDays = value; OnPropertyChanged(); }
        }

        public double[] Prices
        {
            get => _prices;
            set { _prices = value; OnPropertyChanged(); }
        }

        public ICommand GenerateBrownianMotionCommand { get; }

        public MainViewModel()
        {
            GenerateBrownianMotionCommand = new Command(GenerateBrownianMotion);
        }

        private void GenerateBrownianMotion()
        {
            BrownianMotionModel model = new();
            Prices = model.GenerateBrownianMotion(InitialPrice, Volatility, MeanReturn, NumDays);
        }
    }
}

