using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace WPFbasics
{
    public class Model : INotifyPropertyChanged
    {
        public ObservableCollection<string> Measure { get; } = new ObservableCollection<string>();

        #region Property Changed interface implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        #endregion

        #region Current X
        int curx;
        public int Curx
        {
            get { return curx; }
            set
            {
                curx = value;
                OnPropertyRaised("Curx");
            }
        }
        #endregion
        int yalanCurx = 0;

        #region Current Y
        int cury;
        public int Cury
        {
            get { return cury; }
            set
            {
                cury = value;
                OnPropertyRaised("Cury");
            }
        }
        #endregion
        int yalanCury = 0;

        #region Current Z
        int curz;
        public int Curz
        {
            get { return curz; }
            set
            {
                curz = value;
                OnPropertyRaised("Curz");
            }
        }
        #endregion
        int yalanCurz = 0;

        #region Destination X
        int desx;
        public int Desx
        {
            get { return desx; }
            set
            {
                desx = value;
                OnPropertyRaised("Desx");
            }
        }
        #endregion
        int yalanDesx = 0;

        #region Destination Y
        int desy;
        public int Desy
        {
            get { return desy; }
            set
            {
                desy = value;
                OnPropertyRaised("Desy");
            }
        }
        #endregion
        int yalanDesy = 0;

        #region Destination Z
        int desz;
        public int Desz
        {
            get { return desz; }
            set
            {
                desz = value;
                OnPropertyRaised("Desz");
            }
        }
        #endregion
        int yalanDesz = 0;

        #region Destination
        int des;
        public int Des
        {
            get { return des; }
            set
            {
                des = value;
                OnPropertyRaised("des");
            }
        }
        #endregion

        public Model()
        {
            AddCommands = new CommandShow(this);
        }

        #region ICommand Part
        class CommandShow : ICommand
        {
            Model parent;

            public CommandShow(Model parent)
            {
                this.parent = parent;
                parent.PropertyChanged += delegate { CanExecuteChanged.Invoke(this, EventArgs.Empty); };
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter) 
            { 
                return true; 
            }

            public void Execute(object parameter)
            {
                parent.yalanCurx = parent.Curx;
                parent.yalanCury = parent.Cury;
                parent.yalanCurz = parent.Curz;
                parent.yalanDesx = parent.Desx;
                parent.yalanDesy = parent.Desy;
                parent.yalanDesz = parent.Desz;
                //totali ayarlayamadım koymamayı düşünüyorum

                if (parent.Measure.Contains("Current X : " + parent.yalanCurx + "   Destination X : " + parent.yalanDesx + "\nCurrent Y : " + parent.yalanCury + "   Destination Y : " + parent.yalanDesy + "             Total : " + parent.Des + "\nCurrent Z : " + parent.yalanCurz + "   Destination Z : " + parent.yalanDesz))
                {
                    MessageBox.Show("asd");
                }
                else
                {
                    parent.Measure.Add("Current X : " + parent.Curx + "   Destination X : " + parent.Desx + "\nCurrent Y : " + parent.Cury + "   Destination Y : " + parent.Desy + "             Total : " + parent.Des + "\nCurrent Z : " + parent.Curz + "   Destination Z : " + parent.Desz);
                    
                }
            }
        }

        public ICommand AddCommands { get; private set; }
        #endregion

    }
}
