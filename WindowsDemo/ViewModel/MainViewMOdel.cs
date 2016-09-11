using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemo.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private IEnumerable<Prato>  listPrato;
        public IEnumerable<Prato>  ListPratos
        {
            get { return listPrato; }
            set
            {
                if (listPrato != value)
                {
                    listPrato = value;
                    RaisePropertyChanged("ListPratos");
                }
            }
        }

        private Prato selectedPrato;
        public Prato SelectedPrato
        {
            get { return selectedPrato; }
            set
            {
                if (selectedPrato != value)
                {
                    selectedPrato = value;
                    RaisePropertyChanged("SelectedPrato");
                }
            }
        }

        private bool isCasal;
        public bool IsCasal
        {
            get { return isCasal; }
            set
            {
                if (isCasal != value)
                {
                    isCasal = value;
                    RaisePropertyChanged("IsCasal");
                }
            }
        }

        private int pessoas = 1;
        public int Pessoas
        {
            get { return pessoas; }
            set
            {
                if (pessoas != value)
                {
                    pessoas = value;
                    RaisePropertyChanged("Pessoas");
                }
            }
        }

        private decimal total;
        public decimal Total
        {
            get { return total; }
            set
            {
                if (total != value)
                {
                    total = value;
                    RaisePropertyChanged("Total");
                }
            }
        }

        public MainViewModel()
        {
            ListPratos = new Prato[] { new Prato { Nome = "Filé", Preco = 22.50M },
                                       new Prato { Nome = "Frango", Preco = 15.78M },
                                       new Prato { Nome = "Arroz com feijão", Preco = 9.00M }
                                     };
            PropertyChanged += _PropertyChanged;
        }

        private void _PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsCasal")
            {
                if (IsCasal)
                    Pessoas = 2;
            }
            if(SelectedPrato != null && (e.PropertyName == "IsCasal" || e.PropertyName == "Pessoas" || e.PropertyName == "SelectedPrato"))
            {
                var result = SelectedPrato.Preco * pessoas;
                Total = IsCasal ? result * 0.7M : result;
            }
        }

        public class Prato
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
