namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string Byear = textBoxBY.Text;
            string gpa = textBoxgpa.Text;
            int iByear = Int32.Parse(Byear);
            double igpa = double.Parse(gpa);

            Person newPerson = new Person(name, igpa, iByear);
            this.classroom.AddPerson(newPerson);
            this.classroom.addGpa();
            this.textBoxListName.Text = this.classroom.ShowPerons();


            this.textBoxAgeAll.Text = this.classroom.showAge().ToString();

            double newMax = this.classroom.showMax();
            this.textBoxMax.Text = newMax.ToString();
            this.textBoxMaxName.Text = this.classroom.showMaxName();

            double newMin = this.classroom.showMin();
            this.textBoxMin.Text = newMin.ToString();
            this.textBoxMinName.Text = this.classroom.showMinName();

            double newAvg = this.classroom.showAvg();
            this.textBoxAvg.Text = newAvg.ToString("N2");

        }
    }
}