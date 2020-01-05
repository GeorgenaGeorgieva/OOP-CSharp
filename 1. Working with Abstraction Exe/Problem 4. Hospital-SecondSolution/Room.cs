namespace HospitalSecondSolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Room
    {
        private List<Patient> patients;
        private bool isFull;

        public Room()
        {
            this.Patients = new List<Patient>();
        }

        public bool IsFull => this.Patients.Count >= 3;
        public List<Patient> Patients { get; set; }

        public override string ToString()
        {
            StringBuilder printPatientInRoom = new StringBuilder();
            var sortedPatientList = this.Patients.OrderBy(p => p.Name);

            foreach (var patient in sortedPatientList)
            {
                printPatientInRoom.AppendLine(patient.Name);
            }

            return printPatientInRoom.ToString().TrimEnd();
        }

        internal object OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
