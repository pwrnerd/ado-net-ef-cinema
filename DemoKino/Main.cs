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
        MainViewModel m_viewModel = null;

        public Main()
        {
            InitializeComponent();            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DAO.DAO dao = new DAO.DAO();

            dao.Load();

            m_viewModel = new MainViewModel(dao);
            m_viewModel.ModelChanged += M_viewModel_ModelChanged;
            filmBindingSource.DataSource = m_viewModel.FilmCollection;
            saalBindingSource.DataSource = m_viewModel.SaalCollection;
            vorfuehrungBindingSource.DataSource = m_viewModel.VorfuehrungCollection;
            buchungBindingSource.DataSource = m_viewModel.BuchungCollection;

            // Validität überprüfen
            if (!m_viewModel.ValidateBuchung(true))
            {
                dao.Save();
                MessageBox.Show("Ungültige Buchungen wurden in der Datenbank entfernt");
            }
        }

        private void M_viewModel_ModelChanged(object sender, EventArgs e)
        {
            this.dgvVorfuehrung.Invalidate();
            this.dgvBuchung.Invalidate();
            this.dgvSaal.Invalidate();
            this.dgvFilme.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_viewModel.Save();
        }

        private void dgvVorfuehrung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvBuchung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
