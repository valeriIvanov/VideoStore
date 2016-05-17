using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startup
{
    public partial class FormVideoClub : Form
    {
        private FormLogic logic = new FormLogic();
        public FormVideoClub()
        {
            InitializeComponent();
            SelectMovie(true);
            GetGenreName();
            GetOrdersList();

        }

        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logic.AddOrder(textBoxOrderMovieName.Text.ToString(), textBoxOderPersonName.Text.ToString()));
            GetOrdersList();
            textBoxOrderMovieName.Text = "";
            textBoxOderPersonName.Text = "";
        }

        private void buttonInsertPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logic.AddPerson(textBoxPersonName.Text.ToString(), textBoxPersonYear.Text.ToString()));
            textBoxPersonName.Text = "";
            textBoxPersonYear.Text = "";
        }

        private void buttonInsertMovie_Click(object sender, EventArgs e)
        {
            bool adult;
            if (checkBoxAdult.Checked)
            {
                adult = true;
            }
            else { adult = false; };
            MessageBox.Show(logic.AddMovie(textBoxMovieName.Text.ToString(), textBoxDirector.Text.ToString(),
                comboBoxGenre.Text.ToString(), textBoxPrice.Text.ToString(), adult));
            SelectMovie(true);
        }

        private void GetGenreName()
        {
            comboBoxGenre.Items.AddRange(logic.GenreNames());
        }

        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logic.DeleteMovie(textBoxMovieID.Text.ToString(), textBoxMovieName.Text.ToString()));
            textBoxMovieName.Text = "";
            SelectMovie(true);
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logic.DeletePerson(textBoxPersonName.Text.ToString()));
            textBoxPersonName.Text = "";
        }

        private void GetOrdersList()
        {
            var listOrders = logic.SelectOrders(false, textBoxOderPersonName.Text.ToString());
            dataGridViewОverdueOrders.DataSource = listOrders;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logic.DeleteOrder(textBoxOrderNumber.Text.ToString()));
            textBoxOrderNumber.Text = "";
            GetOrdersList();

        }

        private void buttonSerchMovieName_Click(object sender, EventArgs e)
        {
            SelectMovie(false);

        }

        private void buttonShowAllMovies_Click(object sender, EventArgs e)
        {
            SelectMovie(true);
        }

        private void SelectMovie(bool movieSerch)
        {
            var listMovie = logic.SelectMovies(movieSerch, textBoxMovieName.Text.ToString());
            dataGridViewMovie.DataSource = listMovie;
            this.dataGridViewMovie.Columns[0].Visible = false;
        }

        private void dataGridViewMovie_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewMovie.ClearSelection();
        }

        private void dataGridViewОverdueOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewОverdueOrders.ClearSelection();
        }

        private void dataGridViewMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxMovieID.Text = dataGridViewMovie.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxMovieName.Text = dataGridViewMovie.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dataGridViewОverdueOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxOrderNumber.Text = dataGridViewОverdueOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void KeyPresOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void KeyPresOnlyNumberAndDots(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresOnlyNumberAndDots(sender, e);
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresOnlyNumber(sender, e);
        }

        private void textBoxPersonYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresOnlyNumber(sender, e);
        }

        private void textBoxOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresOnlyNumber(sender, e);
        }


        private void dataGridViewPerson_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewPerson.ClearSelection();

        }

        private void dataGridViewPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxPersonID.Text = dataGridViewPerson.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxPersonName.Text = dataGridViewPerson.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void buttonSerchPerson_Click(object sender, EventArgs e)
        {
            SerchPerson();
        }

        private void SerchPerson()
        {
            var personList = logic.SelectPerson(textBoxPersonName.Text.ToString());
            dataGridViewPerson.DataSource = personList;
            this.dataGridViewPerson.Columns[0].Visible = false;
        }

        private void buttonSechOrderByPersonName_Click(object sender, EventArgs e)
        {
            var orderList = logic.SelectOrders(true, textBoxOderPersonName.Text.ToString());
            dataGridViewОverdueOrders.DataSource = orderList;
        }

        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            bool adult;
            if (checkBoxAdult.Checked)
            {
                adult = true;
            }
            else { adult = false; };
            MessageBox.Show(logic.UpdateMovie(textBoxMovieID.Text.ToString(), textBoxMovieName.Text.ToString(), textBoxDirector.Text.ToString(), comboBoxGenre.Text.ToString(), textBoxPrice.Text.ToString(), adult));
            textBoxMovieID.Text = "";
            SelectMovie(true);
        }

        private void buttonUpdatePerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logic.UpdatePerson(textBoxPersonID.Text.ToString(), textBoxPersonName.Text.ToString(), textBoxPersonYear.Text.ToString()));
            SerchPerson();
            textBoxPersonName.Text = "";
            textBoxPersonYear.Text = "";
            textBoxPersonID.Text = "";
        }

        private void buttonAllOrders_Click(object sender, EventArgs e)
        {
            GetOrdersList();

        }


    }
}
