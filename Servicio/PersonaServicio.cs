using practicahoy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace practicahoy.Servicio
{
    public class PersonaServicio
    {
        public ObservableCollection<PersonaModel> personas { get; set; }

        public PersonaServicio()
        {
            if (personas == null)
            {
                personas = new ObservableCollection<PersonaModel>();
            }

        }

        public ObservableCollection<PersonaModel> Consultar()
        {
            return personas;
        }

        public void guardar(PersonaModel persona)
        {
            personas.Add(persona);
        }

        public void modificar(PersonaModel persona)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].id==persona.id)
                {
                    personas[i] = persona;
                }
            }

        }

        public void Eliminar(PersonaModel persona)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].id == persona.id)
                {
                    personas.Remove(persona);
                }
            }
        }


    }
}
