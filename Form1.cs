using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable StudentDetails;
        public Form1()
        {
            InitializeComponent();
            StudentDetails = new DataTable("StudentDtails");
            DataColumn StudentName = new DataColumn("Student Name", typeof(string));
            StudentDetails.Columns.Add(StudentName);
            DataColumn StudentID = new DataColumn("Student ID", typeof(string));
            StudentDetails.Columns.Add(StudentID);
            DataColumn StudentNIC = new DataColumn("NIC", typeof(string));
            StudentDetails.Columns.Add(StudentNIC);
            DataColumn BusFare = new DataColumn("Bus Fare", typeof(string));
            StudentDetails.Columns.Add(BusFare);
            DataColumn From = new DataColumn("Travel From", typeof(string));
            StudentDetails.Columns.Add(From);
            DataColumn Transit = new DataColumn("Transit", typeof(string));
            StudentDetails.Columns.Add(Transit);
            DataColumn TravelTo = new DataColumn("To", typeof(string));
            StudentDetails.Columns.Add(TravelTo);
            DataColumn BusRoute = new DataColumn("Bus Route No.", typeof(string));
            StudentDetails.Columns.Add(BusRoute);
            DataColumn SeasonTicket = new DataColumn("Season Ticket Fare", typeof(string));
            StudentDetails.Columns.Add(SeasonTicket);


            dataGridView1.DataSource = StudentDetails;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float seasonTicket;
            seasonTicket = float.Parse(txtBusFare.Text) / 4 * 2 * 23;
            txtSeasonFare.Text = Convert.ToString(seasonTicket);

            StudentDetails.Rows.Add(txtName.Text, txtID.Text, txtNIC.Text, txtBusFare.Text, txtFrom.Text, txtTransit.Text, txtTo.Text, txtBusRoute.Text, txtSeasonFare.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtID.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtFrom.Text = string.Empty;
            txtTransit.Text = string.Empty;
            txtBusRoute.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtBusRoute.Text = string.Empty;
            txtSeasonFare.Text = string.Empty;
            txtBusFare.Text = string.Empty;
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
