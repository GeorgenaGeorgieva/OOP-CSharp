namespace HospitalSecondSolution
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
     
    public class Department
    {
        private string name;
        private List<Room> rooms;

        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new List<Room>();
            CreateRooms();
        }

        public string Name { get; set; }
        
        public List<Room> Rooms { get; set; }

        public void AddPatientToRoom(Patient patient)
        {
            var currentRoom = this.Rooms.FirstOrDefault(r => !r.IsFull);

            if (currentRoom != null)
            {
                currentRoom.Patients.Add(patient);
            }
        }

        public override string ToString()
        {
            StringBuilder printPatients = new StringBuilder();
            
            foreach (var room in this.Rooms)
            {
                foreach (var patient in room.Patients)
                {
                    printPatients.AppendLine(patient.Name);
                }
            }

            return printPatients.ToString().TrimEnd();
        }

        private void CreateRooms()
        {
            for (int i = 0; i < 20; i++)
            {
                this.Rooms.Add(new Room());
            }
        }
    }
}
