using practicahoy.Model;
using practicahoy.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practicahoy.ViewModel
{
    public class PersonaViewModel :PersonaModel
    {
        public ObservableCollection<PersonaModel> persona { get; set; }

        PersonaServicio servicio = new PersonaServicio();
        PersonaModel modelo;

        public PersonaViewModel()
        {
            persona = servicio.Consultar();
            guardarCommand = new Command(async ()=>await guardar(),()=>!IsBusy);
            EliminarCommand = new Command(async ()=>await Eliminar(),()=>!IsBusy);
            editarCommand = new Command(async ()=>await Editar(),()=>!IsBusy);
            LimpiarCommand = new Command(Limpiar(),()=>!IsBusy);
        }

        public Command guardarCommand
        {
            get;
            set;
        }
        public Command editarCommand
        {
            get;
            set;
        }
        public Command EliminarCommand
        {
            get;
            set;
        }
        public Command LimpiarCommand
        {
            get;
            set;
        }
        
        private async Task guardar()
        {
            IsBusy = true;
            Guid IdPersona=Guid.NewGuid();
            modelo = new PersonaModel()
            {
                nombre = nombre,
                Apellido = Apellido,
                Edad = Edad,
                id = IdPersona.ToString(),
            };

            servicio.guardar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }

       
        private async Task Editar()
        {
            IsBusy = true;
            Guid IdPersona = Guid.NewGuid();
            modelo = new PersonaModel()
            {
                nombre = nombre,
                Apellido = Apellido,
                Edad = Edad,
                id = id,
            };

            servicio.modificar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task Eliminar()
        {
            PersonaModel model = persona.FirstOrDefault();
        }

        private async Task Limpiar()
        {
            nombre = "";
            Apellido = "";
            Edad = 0;
            id = "";
        }



    }
}