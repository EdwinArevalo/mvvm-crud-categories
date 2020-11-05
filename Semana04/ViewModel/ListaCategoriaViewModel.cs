using System.Collections.ObjectModel; 
using System.Windows.Input;
using System.Windows; 
using Entity;

namespace Semana04.ViewModel
{
    public class ListaCategoriaViewModel: ViewModelBase
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public ICommand NuevoCommand { get; set; }
        public ICommand ConsultarCommand { get; set; }
        public ListaCategoriaViewModel()
        {
            Categorias = new Model.CategoriaModel().Categorias;

            NuevoCommand = new RelayCommand<Window>(
                param => Abrir()
            );

            ConsultarCommand = new RelayCommand<object>(
                o => { Categorias = (new Model.CategoriaModel()).Categorias; }
            );

            void Abrir()
            {
                View.ManCategoria window = new View.ManCategoria();
                window.ShowDialog();
            }
        }

    }
}
