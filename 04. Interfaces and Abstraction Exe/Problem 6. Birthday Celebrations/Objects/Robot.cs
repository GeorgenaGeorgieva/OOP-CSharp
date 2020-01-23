namespace BirthdayCelebrations.Objects
{
    using Interfaces;
    using System;

    public class Robot : IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model!");
                }

                this.model = value;
            }
        }
        public string Id
        {
            get { return this.id; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid ID!");
                }

                this.id = value;
            }
        }
    }
}
