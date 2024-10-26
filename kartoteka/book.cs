using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kartoteka
{
    public class book
    {
        private int id;
        private string name;
        private string description;
        private string link;
        private string availiability;

        public book(int id, string name, string description, string link, string availiability)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.link = link;
            this.availiability = availiability;

        }

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Link { get => link; set => link = value; }
        public string Availiability { get => availiability; set => availiability = value; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Description + " " + Link + " " + Availiability;
        }

        public static bool operator ==(book a, book b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(book a, book b) { return !(a == b); }
    }
}
