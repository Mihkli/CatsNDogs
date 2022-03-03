using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsAndDogs
{
    public partial class Form1 : Form
    {
        string connectiontostring;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connectiontostring = ConfigurationManager.ConnectionStrings["CatsAndDogs.Properties.Settings.PetsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePetsTable();
        }

        private void PopulatePetsTable()
        {
            using(connection = new SqlConnection(connectiontostring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PetType", connection))
            
            {
                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                ListPets.DisplayMember = "PetTypeName";
                ListPets.ValueMember = "Id";
                ListPets.DataSource = petTable;
            }
        }

        private void ListPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePetNames();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void PopulatePetNames()
        {
            string query = "SELECT Pet.Name FROM PetType INNER JOIN Pet On Pet.TypeId = PetType.Id WHERE PetType.Id = @TypeId";
            using (connection = new SqlConnection(connectiontostring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", ListPets.SelectedValue);
                DataTable petNameTable = new DataTable();
                adapter.Fill(petNameTable);

                ListPetNames.DisplayMember = "Name";
                ListPetNames.ValueMember = "Id";
                ListPetNames.DataSource = petNameTable;
            }
                
        }

    }
}
