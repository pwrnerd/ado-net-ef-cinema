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
        MainViewModel m_viewModel = null;

        public Main()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dao.Load();

            m_viewModel = new MainViewModel(dao.mKino.Film.Local, dao.mKino.Vorfuehrung.Local, dao.mKino.Buchung.Local, dao.mKino.Saal.Local);
            m_viewModel.ModelChanged += M_viewModel_ModelChanged;            
            filmBindingSource.DataSource = m_viewModel.FilmCollection;
            saalBindingSource.DataSource = m_viewModel.SaalCollection;
            vorfuehrungBindingSource.DataSource = m_viewModel.VorfuehrungCollection;
            buchungBindingSource.DataSource = m_viewModel.BuchungCollection;
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
