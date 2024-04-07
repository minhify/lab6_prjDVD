using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6_prjDVD
{
    public partial class frmDVDLibrary : Form
    {
        int CodeNo;
        string lang;
        int subtitle;
        decimal price;
        //bool status;

        public frmDVDLibrary()
        {
            InitializeComponent();
        }

        private void frmDVDLibrary_Load(object sender, EventArgs e)
        {
            List<string> items = new List<string>() {"Tiếng Việt", "Tiếng Anh", "Tiếng Trung", "Tiếng Ả Rập" };
            cbLang.DataSource = items;
        } 

        public void Resetfields(bool status)
        {
            tbDVDNumber.Clear();
            tbDVDTitle.Clear();
            cbLang.SelectedIndex = -1;
            nrPrice.Value = nrPrice.Minimum;
            rbNo.Checked = status;
            rbYes.Checked = status;
            btnAdd.Enabled = !status;
            btnCancel.Enabled = status;
            btnSave.Enabled = status;

            tbDVDTitle.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("select max(DVDCodeNo) from DVDLibrary", clsDatabase.con);
                CodeNo = Convert.ToInt32(cmd.ExecuteScalar());
                clsDatabase.CloseConnection();

            } catch(Exception) 
            {
                CodeNo = 0; 
            }
            CodeNo++;
            Resetfields(true);
            tbDVDNumber.Text = CodeNo.ToString(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> emptyFields = new List<string>();
                if (string.IsNullOrEmpty(tbDVDTitle.Text))
                    emptyFields.Add("DVD Title");
                if (string.IsNullOrEmpty(lang))
                    emptyFields.Add("Language");
                if (price == 0)  
                    emptyFields.Add("Price cannot be 0");

                if (emptyFields.Any())
                {
                    string empytyError = "Please fill the following fields: \n- " + string.Join("\n- ", emptyFields);
                    MessageBox.Show(empytyError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string strInsert = "INSERT INTO DVDLibrary VALUES (@DVDCodeNo, @DVDTitle, @Lang, @Subtitle, @Price)";
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@DVDCodeNo", SqlDbType.Int);
                p1.Value = CodeNo;

                SqlParameter p2 = new SqlParameter("@DVDTitle", SqlDbType.NVarChar);
                p2.Value = tbDVDTitle.Text;

                SqlParameter p3 = new SqlParameter("@Lang", SqlDbType.NVarChar);
                p3.Value = lang;

                SqlParameter p4 = new SqlParameter("@Subtitle", SqlDbType.Bit);
                p4.Value = subtitle;

                SqlParameter p5 = new SqlParameter("@Price", SqlDbType.Money);
                p5.Value = price;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!");

                clsDatabase.CloseConnection();
                Resetfields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Resetfields(false);
        }

        private void nrPrice_ValueChanged(object sender, EventArgs e)
        {
            price = nrPrice.Value;
        }

        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLang.SelectedIndex == -1) {
                lang = "";
                return;
            }
            lang = cbLang.Text;
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            subtitle = 1;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            subtitle = 0;
        }   
    }
}
