using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Transactions;

namespace Lista_Telefonica
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=dblista";

        private int ?id_cont_selecionado=null;
        public Form1(MySqlConnection conexao)
        {
            Conexao = conexao;
        }

        public Form1()
        {

            InitializeComponent();
            list_cont.View = View.Details;
            list_cont.LabelEdit = true;
            list_cont.AllowColumnReorder = true;
            list_cont.FullRowSelect = true;
            list_cont.GridLines = true;
            list_cont.Columns.Add("ID", 30, HorizontalAlignment.Left);
            list_cont.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            list_cont.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            list_cont.Columns.Add("Tipo", 80, HorizontalAlignment.Left);
            list_cont.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            list_cont.Columns.Add("Tipo", 80, HorizontalAlignment.Left);
            list_cont.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            list_cont.Columns.Add("Tipo", 80, HorizontalAlignment.Left);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs? e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {

                e.Handled = true;

                e = null;

            }
        }




        private void Save_Click(object sender, EventArgs e)
        {



            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd1 = new MySqlCommand();
                
                cmd.Connection = Conexao;
                cmd1.Connection = Conexao;
                


                if (id_cont_selecionado == null)
                {

                    cmd.CommandText = "INSERT INTO  agenda (nome) VALUES(@nome);";
                    cmd1.CommandText = "INSERT INTO  telefone (numero,tipo,numero2,tipo2,numero3,tipo3) VALUES(@numero,@tipo,@numero2,@tipo2,@numero3,@tipo3);";
                   

                    cmd.Parameters.AddWithValue("@nome", Nome.Text);
                    cmd1.Parameters.AddWithValue("@tipo", Tipo.Text);
                    cmd1.Parameters.AddWithValue("@numero", Numero.Text);
                    cmd1.Parameters.AddWithValue("@tipo2", Tipo2.Text);
                    cmd1.Parameters.AddWithValue("@numero2", Numero2.Text);
                    cmd1.Parameters.AddWithValue("@tipo3", Tipo3.Text);
                    cmd1.Parameters.AddWithValue("@numero3", Numero3.Text);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    
                    MessageBox.Show("Contato Salvo", "Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    id_cont_selecionado = null;

                    Nome.Text = String.Empty;
                    Tipo.SelectedIndex = -1;
                    Numero.Text = "";
                    Tipo2.SelectedIndex = -1;
                    Numero2.Text = "";
                    Tipo3.SelectedIndex = -1;
                    Numero3.Text = "";



                }
                else
                {

                    cmd.CommandText = "UPDATE agenda SET nome =@nome WHERE id_pessoa=@id";
                    cmd1.CommandText = "UPDATE telefone SET tipo =@tipo, numero=@numero, tipo=@tipo2, numero2=@numero2, tipo3=@tipo3,numero3=@numero3 WHERE id_tel=@id ";


                    cmd.Parameters.AddWithValue("@nome", Nome.Text);
                    cmd.Parameters.AddWithValue("@id", id_cont_selecionado);
                    cmd1.Parameters.AddWithValue("@tipo", Tipo.Text);
                    cmd1.Parameters.AddWithValue("@numero", Numero.Text);
                    cmd1.Parameters.AddWithValue("@tipo2", Tipo2.Text);
                    cmd1.Parameters.AddWithValue("@numero2", Numero2.Text);
                    cmd1.Parameters.AddWithValue("@tipo3", Tipo3.Text);
                    cmd1.Parameters.AddWithValue("@numero3", Numero3.Text);
                    cmd1.Parameters.AddWithValue("@id", id_cont_selecionado);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Contato Atualizado", "Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    id_cont_selecionado = null;

                    Nome.Text = String.Empty;
                    Tipo.SelectedIndex = -1;
                    Numero.Text = "";
                    Tipo2.SelectedIndex = -1;
                    Numero2.Text = "";
                    Tipo3.SelectedIndex = -1;
                    Numero3.Text = "";



                }

            }



            catch (MySqlException ex)
            {
                MessageBox.Show("Erro occurrei: " + ex.Message,
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erroor" + ex.Message,
        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void Busca_Click(object sender, EventArgs e)
        {

            try
            {

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;


                cmd.CommandText = "SELECT agenda.id_pessoa,agenda.nome,telefone.numero,telefone.tipo,telefone.numero2,telefone.tipo2,telefone.numero3,telefone.tipo3 FROM agenda INNER JOIN telefone ON agenda.id_pessoa = telefone.id_tel WHERE agenda.nome LIKE  @b or numero LIKE @b";



                cmd.Parameters.AddWithValue("@b", "%" + Pesquisa.Text + "%");


                MySqlDataReader reader = cmd.ExecuteReader();

                list_cont.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5), 
                        reader.GetString(6),
                        reader.GetString(7),


                };

                    list_cont.Items.Add(new ListViewItem(row));
                }
            }



            catch (MySqlException ex)
            {
                MessageBox.Show("Erro occurr: " + ex.Message,
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erroor" + ex.Message,
        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.Close();
            }
        }


        private void list_cont_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_sele = list_cont.SelectedItems;

            foreach (ListViewItem item in itens_sele){

                id_cont_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                
                Nome.Text = item.SubItems[1].Text;
                Numero.Text = item.SubItems[2].Text;
                Tipo.Text = item.SubItems[3].Text;
                Numero2.Text = item.SubItems[4].Text;
                Tipo2.Text = item.SubItems[5].Text;
                Numero3.Text = item.SubItems[6].Text;
                Tipo3.Text = item.SubItems[7].Text;

                Excluir.Visible = true;


            }
        }

        private void Resetar_Click(object sender, EventArgs e)
        {
            id_cont_selecionado = null;

            Nome.Text = String.Empty;
            Tipo.SelectedIndex = -1;
            Numero.Text= "";
            Tipo2.SelectedIndex = -1;
            Numero2.Text = "";
            Tipo3.SelectedIndex = -1;
            Numero3.Text = "";

            list_cont.Items.Clear();

            Nome.Focus();
            
            Excluir.Visible = false;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluir_cont();   
           
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            excluir_cont();
       }


        private void excluir_cont()
        {
            try
            {
                DialogResult Conf = MessageBox.Show("Deseja Excluir o Contato?", "Tem certeza?", MessageBoxButtons.YesNo);

                if (Conf == DialogResult.Yes)
                {
                    Conexao = new MySqlConnection(data_source);

                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd.Connection = Conexao;
                    cmd1.Connection = Conexao;

                    cmd.CommandText = "Delete FROM agenda WHERE id_pessoa=@id";
                    cmd1.CommandText = "Delete FROM telefone WHERE id_tel=@id ";



                    cmd.Parameters.AddWithValue("@id", id_cont_selecionado);

                    cmd1.Parameters.AddWithValue("@id", id_cont_selecionado);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();






                    MessageBox.Show("Contato Excluido Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    list_cont.Items.Clear();

                    id_cont_selecionado = null;

                    Nome.Text = String.Empty;
                    Tipo.SelectedIndex = -1;
                    Numero.Text = "";
                    Tipo2.SelectedIndex = -1;
                    Numero2.Text = "";
                    Tipo3.SelectedIndex = -1;
                    Numero3.Text = "";

                    Nome.Focus();


                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro occurr: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro occurr: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}










