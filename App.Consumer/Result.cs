using System.Collections.Generic;

namespace App.Consumer
{
    public class Result
    {
        public class Mensagem
        {
            public SchemaPrimary Schema { get; set; }
            public Payload Payload { get; set; }
        }

        public class SchemaPrimary
        {
            public string Type { get; set; }
            public ICollection<FieldsPrimary> Fields { get; set; }
            public bool Optional { get; set; }
            public string Name { get; set; }
        }

        public class FieldsPrimary
        {
            public string Type { get; set; }
            public ICollection<FieldChield> Fields { get; set; }
            public bool Optional { get; set; }
            public string Field { get; set; }
            public string Name { get; set; }
        }

        public class FieldChield
        {
            public string Type { get; set; }
            public bool Optional { get; set; }
            public string Field { get; set; }
        }

        public class Payload
        {
            public Entities Before { get; set; }
            public Entities After { get; set; }
        }

        public class Entities
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
        }

        public class KeyIndentification
        {
            public Identification Payload { get; set; }
        }

        public class Identification
        {
            public int Id { get; set; }
        }
    }
}