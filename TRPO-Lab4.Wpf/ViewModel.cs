using System;
using System.ComponentModel;
using TRPO_Lab3.Lib.TRPO_Lab3.Lib;

namespace TRPO_Lab4.Wpf
{
    public class ViewModel : INotifyPropertyChanged
    {
        private double _P1;
        private double _P2;
        private double _h;

        public double P1
        {
            get { return _P1; }
            set
            {
                _P1 = value;
                RaisePropertyChanged(nameof(P1));
                RaisePropertyChanged(nameof(area));
            }
        }

        public double P2
        {
            get { return _P2; }
            set
            {
                _P2 = value;
                RaisePropertyChanged(nameof(P2));
                RaisePropertyChanged(nameof(area));
            }
        }

        public double h
        {
            get { return _h; }
            set
            {
                _h = value;
                RaisePropertyChanged(nameof(h));
                RaisePropertyChanged(nameof(area));
            }
        }

        public double area
        {
            get
            {
                try
                {
                    return  SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
