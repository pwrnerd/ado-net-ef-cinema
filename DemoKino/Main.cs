using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace DemoKino
{
    public partial class Main : Form
    {
        DAO.DAO dao = new DAO.DAO();

        public Main()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dao.Load();

/*            dgvFilme.DataSource = dao.mKino;
            dgvFilme.DataMember = "Film";
            dgvSaal.DataSource = dao.mKino;
            dgvSaal.DataMember = "Saal";
            dgvVorfuehrung.DataSource = dao.mKino;
            dgvVorfuehrung.DataMember = "Vorfuehrung";
            dgvBuchung.DataSource = dao.mKino;
            dgvBuchung.DataMember = "Buchung"; */
            
            filmBindingSource.DataSource = dao.mKino.Film.Local;
            saalBindingSource.DataSource = dao.mKino.Saal.Local;
            vorfuehrungBindingSource.DataSource = dao.mKino.Vorfuehrung.Local;
            buchungBindingSource.DataSource = dao.mKino.Buchung.Local;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dao.Save();
        }

        private void dgvVorfuehrung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvBuchung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
