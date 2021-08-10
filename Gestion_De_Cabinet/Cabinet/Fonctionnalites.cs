using System;
using System.Collections.Generic;
using System.Text;

namespace Cabinet
{
    interface IFonctionnalites
    {
        public int CountSecretary();
        public int CountDoctor();
        public int CountPatient();
        public void S_Engager();
        public void AddPatient(Patient lamba);
        public void RemovePatient(Patient lambda);
        public void UpdateNom(string newName);
        public void UpdatePrenom(string newName);
        public void UpdateNomPatient(Patient lambda,string newName);
        public void UpdatePrenomPatient(Patient lambda,string newName);
    }
}
