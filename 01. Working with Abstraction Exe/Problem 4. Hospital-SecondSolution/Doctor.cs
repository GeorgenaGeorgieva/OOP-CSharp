namespace HospitalSecondSolution
{
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
     
    public class Doctor
    {
        private string firstName;
        private string lastName;
        private List<Patient> patients;

        public Doctor(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patients = new List<Patient>();
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string FullName => this.FirstName + " " + this.LastName;
        
        public List<Patient> Patients { get; set; }

        public void AddPatientToPatientsList(Patient patient)
        {
            this.Patients.Add(patient);
        }

        public override string ToString()
        {
            var printPatientsList = new StringBuilder();
            var sortedPatientsList = this.Patients.OrderBy(p => p.Name);

            foreach (var patient in sortedPatientsList)
            {
                printPatientsList.AppendLine(patient.Name);
            }

            return printPatientsList.ToString().TrimEnd();
        }
    }
}
