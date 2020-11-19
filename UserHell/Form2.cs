using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserHell
{
    public partial class Form2 : Form
    {
        Random rand = new Random();
        Color[] color = UserInterface.color;

        string[] firstNames = new String[]
        {
            "Takashi",
            "Lenuete",
            "Amando",
            "Esthiru",
            "Mac",
            "Jong",
            "Sharma",
            "Josif",
            "Neil",
            "Bruce",
            "Cassandra",
            "Amelia",
            "Amara",
            "Isabela",
            "Noel"

        };

        string[] lastNames = new String[]
        {
            "Lester",
            "Marconi",
            "Waldfogel",
            "Bretz",
            "Diarmada",
            "MacConnel",
            "Cardoso",
            "Neil",
            "Watson"
        };


        public Form2()
        {
            InitializeComponent();

            
            Person[] people = new Person[rand.Next(12, 44)];


            CreatePeople(people);
            this.listView1.ItemActivate += new EventHandler(CourseListView__ItemActivate);
            //this.listView1.SelectedIndexChanged += new EventHandler(CourseListView__SelectedIndexChanged);
            
            PaintListView(people);
        }

        private void PaintListView(Person[] people)
        {
            ListViewItem lvi = null;
            ListViewItem.ListViewSubItem lvsi = null;
            ListViewItem firstLVI = null;

            int lviCntr = 0;

            for (int i = 0; i < people.Length; i++)
            {
                lvi = new ListViewItem();
                lvi.Text = people[i].FirstName;

                if (lviCntr % 2 == 0) 
                {
                    lvi.BackColor = color[rand.Next(1, color.Length - 1)];
                }
                else
                {
                    lvi.BackColor = color[rand.Next(1, color.Length - 1)];
                }

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = people[i].LastName;
                lvi.SubItems.Add(lvsi);
            }
        }

        private void CourseListView__ItemActivate(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
        }

        private void CreatePeople(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person();
                person.FirstName = firstNames[rand.Next(1, firstNames.Length)];
                person.LastName = lastNames[rand.Next(1, lastNames.Length)];
                person.Age = rand.Next(17, 99);
                person.Money = rand.Next(210 + person.Age, 7000 - (person.Age * 3));


                people[i] = person;
            }
        }
    }

    public class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return FirstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return LastName; }
            set { lastName = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int money;
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
