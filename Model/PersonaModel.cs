using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace practicahoy.Model
{
  


    
    public class PersonaModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String nombre = "")
        {

        }
        public string id { 
            get; set; }
        public int Mensaje { get; set; }
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool IsBusy { get; set; }
    }
}
