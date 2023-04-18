using Practice14_Grebenukov;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Practice14_Forms
{
    public partial class Form1 : Form
    {
        static string CheckString(TextBox tb)
        {
            bool test = false;
            if (tb.TextLength == 0)
            {

                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            else
            {
                foreach (char c in tb.Text)
                {
                    if (!char.IsLetter(c))
                        test = true;

                }
                if (test == true)
                {
                    tb.BackColor = Color.LightCoral;
                    tb.Text = "0";
                }
                else
                    return tb.Text;
            }
            return tb.Text;
        }
        static string CheckAddress(TextBox tb)
        {
            if (tb.TextLength == 0)
            {
                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            else
            {
                return tb.Text;
            }
            return tb.Text;
        }
        static double CheckDoubleNumber(TextBox tb)
        {

            try
            {
                if (Convert.ToDouble(tb.Text) > 0)
                {
                    return Convert.ToDouble(tb.Text);
                }
            }
            catch (Exception)
            {
                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            return Convert.ToDouble(tb.Text);
        }
        static int CheckNumber(TextBox tb)
        {

            try
            {
                if (int.Parse(tb.Text) > 0)
                {
                    return int.Parse(tb.Text);
                }
            }
            catch (Exception)
            {
                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            return int.Parse(tb.Text);
        }
        private void InitDataGridCar()
        {
            StreamReader sr = File.OpenText("car.txt");
            while (!sr.EndOfStream)
            {
                string dataString = sr.ReadLine();
                string[] ss = dataString.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                dataGridView3.Rows.Add(ss[0], ss[1], ss[2], ss[3], ss[4], ss[5]);
            }
            sr.Close();
        }

        private List<Car> AddDataListCar()
        {
            StreamReader sr = File.OpenText("car.txt");
            List<Car> listCar = new List<Car>();
           
            while (!sr.EndOfStream)
            {
                
                string dataCar = sr.ReadLine();
                string[] ss = dataCar.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                listCar.Add(new Car(ss[0], int.Parse(ss[1]), ss[2], ss[3], 
                    double.Parse(ss[4]), int.Parse(ss[5])));


            }

            return listCar;

        }

        private List<RealEstate> AddDataListRealEstate()
        {
            StreamReader sr = File.OpenText("realEstate.txt");
            List<RealEstate> listRealEstate = new List<RealEstate>();

            while (!sr.EndOfStream)
            {

                string dataRealEstate = sr.ReadLine();
                string[] ss = dataRealEstate.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                listRealEstate.Add(new RealEstate(ss[0], ss[1], ss[2],
                    double.Parse(ss[3]), int.Parse(ss[4])));


            }

            return listRealEstate;

        }
        private void InitDataGridRealEstate()
        {
            StreamReader sr = File.OpenText("realEstate.txt");
            while (!sr.EndOfStream)
            {
                string dataString = sr.ReadLine();
                string[] ss = dataString.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                dataGridView3.Rows.Add(ss[0], ss[1], ss[2], ss[3], ss[4]);
            }
            sr.Close();
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car(CheckString(textBoxBrandCar), (int)numericUpDownYearcar.Value, CheckString(textBoxSurnameCar),
                    CheckString(textBoxNameOfTheSubjectOfInsuranceCar), CheckDoubleNumber(textBoxPriceCar), CheckNumber(textBoxTermCar));
                if (textBoxBrandCar.Text == "0" || textBoxSurnameCar.Text == "0" ||
                    textBoxNameOfTheSubjectOfInsuranceCar.Text == "0" || textBoxPriceCar.Text == "0" ||
                    textBoxTermCar.Text == "0")
                {
                    MessageBox.Show("������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter sw_car = File.AppendText("car.txt");
                    sw_car.WriteLine($"{car.Brand}&{car.YearOfIssue}&{car.Surname}&{car.NameOfTheSubjectOfInsurance}&{car.InsuranceCost}&{car.TermOfInsurance}");
                    sw_car.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("������");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRealEState_Click(object sender, EventArgs e)
        {
            try
            {
                RealEstate realEstate = new RealEstate(CheckAddress(textBoxAddres), CheckString(textBoxSurnameRealEstate),
                    ComboBoxNameOfTheSubjectOfInsuranceRealEstate.Text, CheckDoubleNumber(textBoxPriceRealEstate), CheckNumber(textBoxTermRealEstate));
                if (textBoxAddres.Text == "0" || textBoxSurnameRealEstate.Text == "0" || 
                    ComboBoxNameOfTheSubjectOfInsuranceRealEstate.SelectedIndex > ComboBoxNameOfTheSubjectOfInsuranceRealEstate.Items.Count || 
                    textBoxPriceRealEstate.Text == "0" || textBoxTermRealEstate.Text == "0")
                {
                    MessageBox.Show("������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter sw_realEstate = File.AppendText("realEstate.txt");
                    sw_realEstate.WriteLine($"{realEstate.Address}&{realEstate.Surname}&{realEstate.NameOfTheSubjectOfInsurance}&{realEstate.InsuranceCost}&{realEstate.TermOfInsurance}");
                    sw_realEstate.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("������");
            }
        }

        private void comboBoxChoiceOfInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoiceOfInsurance.Text == "��������� �� ������")
            {
                dataGridView3.Rows.Clear();
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("������ ������", "������ ������");
                dataGridView3.Columns.Add("��� �������", "��� �������");
                dataGridView3.Columns.Add("������� �����������", "������� �����������");
                dataGridView3.Columns.Add("������� ���������", "������� ���������");
                dataGridView3.Columns.Add("��������� ���������", "��������� ���������");
                dataGridView3.Columns.Add("���� ���������", "���� ���������");
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                InitDataGridCar();
            }
            else if (comboBoxChoiceOfInsurance.Text == "��������� �� ������������")
            {
                dataGridView3.Rows.Clear();
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("����� ������������", "����� ������������");
                dataGridView3.Columns.Add("������� �����������", "������� �����������");
                dataGridView3.Columns.Add("������� ���������", "������� ���������");
                dataGridView3.Columns.Add("��������� ���������", "��������� ���������");
                dataGridView3.Columns.Add("���� ���������", "���� ���������");
                groupBox4.Visible = true;
                groupBox3.Visible = false;
                InitDataGridRealEstate();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (comboBoxChoiceOfInsurance.Text == "��������� �� ������")
            {
                int del = dataGridView3.CurrentCell.RowIndex;
                dataGridView3.Rows.RemoveAt(del);
                List<string> lines = File.ReadAllLines("car.txt").ToList();
                lines.RemoveAt(del);
                File.WriteAllLines("car.txt", lines);

            }
            else if (comboBoxChoiceOfInsurance.Text == "��������� �� ������������")
            {
                int del = dataGridView3.CurrentCell.RowIndex;
                dataGridView3.Rows.RemoveAt(del);
                List<string> lines = File.ReadAllLines("realEstate.txt").ToList();
                lines.RemoveAt(del);
                File.WriteAllLines("realEstate.txt", lines);
            }
        }

        private void �����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.ReadOnly = false;
        }

        private void �����������������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (comboBoxChoiceOfInsurance.Text == "��������� �� ������")
            {
                try
                {
                    bool flag = true;
                    string check;
                    for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                    {
                        check = dataGridView3.Rows[j].Cells[1].Value.ToString();
                        for (int i = 0; i < check.Length; i++)
                        {
                            if (!Char.IsNumber(check[i]))
                            {
                                flag = false;
                            }
                        }

                    }
                    if (flag == true)
                    {
                        for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                        {
                            check = dataGridView3.Rows[j].Cells[4].Value.ToString();
                            for (int i = 0; i < check.Length; i++)
                            {
                                if (!Char.IsNumber(check[i]))
                                {
                                    flag = false;
                                }
                            }

                        }
                    }
                    if (flag == true)
                    {
                        for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                        {
                            check = dataGridView3.Rows[j].Cells[5].Value.ToString();
                            for (int i = 0; i < check.Length; i++)
                            {
                                if (!Char.IsNumber(check[i]))
                                {
                                    flag = false;
                                }
                            }

                        }
                    }

                    if (flag == true)
                    {
                        StreamWriter sw1 = File.CreateText("car.txt");

                        for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                        {
                            for (int i = 0; i < dataGridView3.Rows[j].Cells.Count; i++)
                            {
                                sw1.Write(dataGridView3.Rows[j].Cells[i].Value + "&");
                            }
                            sw1.WriteLine();
                        }
                        sw1.Close();

                        MessageBox.Show("���� ������� ��������");
                        dataGridView3.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("������ ��� ���������� �����!");
                        dataGridView3.ReadOnly = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� �����!");
                    dataGridView3.ReadOnly = true;
                }
            }
            else if (comboBoxChoiceOfInsurance.Text == "��������� �� ������������")
            {
                try
                {
                    bool flag = true;
                    string check;
                    for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                    {
                        check = dataGridView3.Rows[j].Cells[3].Value.ToString();
                        for (int i = 0; i < check.Length; i++)
                        {
                            if (!Char.IsNumber(check[i]))
                            {
                                flag = false;
                            }
                        }

                    }
                    if (flag == true)
                    {
                        for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                        {
                            check = dataGridView3.Rows[j].Cells[4].Value.ToString();
                            for (int i = 0; i < check.Length; i++)
                            {
                                if (!Char.IsNumber(check[i]))
                                {
                                    flag = false;
                                }
                            }

                        }
                    }
                    if (flag == true)
                    {
                        StreamWriter sw1 = File.CreateText("realEstate.txt");

                        for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                        {
                            for (int i = 0; i < dataGridView3.Rows[j].Cells.Count; i++)
                            {
                                sw1.Write(dataGridView3.Rows[j].Cells[i].Value + "&");
                            }
                            sw1.WriteLine();
                        }
                        sw1.Close();

                        MessageBox.Show("���� ������� ��������");
                        dataGridView3.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("������ ��� ���������� �����!");
                        dataGridView3.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� �����!");
                    dataGridView3.ReadOnly = true;
                }
            }
            
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.ReadOnly = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = true;
            groupBox3.Visible = true;
            string filter = textBoxSearch.Text.Trim();
            string columnName = "";
            if (comboBoxChoiceOfInsurance.Text == "��������� �� ������")
            {
                List<Car> listCar = AddDataListCar();
                if (radioButtonBrandCar.Checked) columnName = "������ ������";
                else if (radioButtonYearCar.Checked) columnName = "��� �������";
                else if (radioButtonSurnameCar.Checked) columnName = "������� �����������";
                else if (radioButtonItemCar.Checked) columnName = "������� ���������";
                else if (radioButtonPriceHighCar.Checked) columnName = "��������� ��������� ������";
                else if (radioButtonPriceLowCar.Checked) columnName = "��������� ��������� ������";
                else if (radioButtontermHighCar.Checked) columnName = "���� ��������� ������";
                else if (radioButtonTermLowCar.Checked) columnName = "���� ��������� ������";
                List<Car> filteredCar = new List<Car>();
                foreach (Car new_car in listCar)
                {
                    if (columnName == "������ ������")
                    {
                        if (new_car.Brand.ToString().Contains(filter))
                            filteredCar.Add(new_car);
                    }
                    else if (columnName == "��� �������")
                    {
                        if (int.TryParse(filter, out int filterValue))
                        {
                            if (new_car.YearOfIssue >= int.Parse(filter))
                                filteredCar.Add(new_car);
                        }
                    }
                    else if (columnName == "������� �����������")
                    {
                        if (new_car.Surname.Contains(filter))
                            filteredCar.Add(new_car);
                    }
                    else if (columnName == "������� ���������")
                    {
                        if (new_car.NameOfTheSubjectOfInsurance.Contains(filter))
                                filteredCar.Add(new_car);
                    }
                    else if (columnName == "��������� ��������� ������")
                    {
                        if (double.TryParse(filter, out double filterValue))
                        {
                            if (new_car.InsuranceCost >= filterValue)
                                filteredCar.Add(new_car);
                        }
                    }
                    else if (columnName == "��������� ��������� ������")
                    {
                        if (double.TryParse(filter, out double filterValue))
                        {
                            if (new_car.InsuranceCost <= filterValue)
                                filteredCar.Add(new_car);
                        }
                    }
                    else if (columnName == "���� ��������� ������")
                    {
                        if (int.TryParse(filter, out int filterValue))
                        {
                            if(new_car.TermOfInsurance >= filterValue)
                                filteredCar.Add(new_car);
                        }
                    }
                    else if (columnName == "���� ��������� ������")
                    {
                        if (int.TryParse(filter, out int filterValue))
                        {
                            if (new_car.TermOfInsurance <= filterValue)
                                filteredCar.Add(new_car);
                        }
                    }
                }

                dataGridView3.Rows.Clear();
                foreach (Car new_car in filteredCar)
                {
                    dataGridView3.Rows.Add(new_car.Brand, new_car.YearOfIssue, new_car.Surname, new_car.NameOfTheSubjectOfInsurance, new_car.InsuranceCost, new_car.TermOfInsurance);
                }
            }
            else if (comboBoxChoiceOfInsurance.Text == "��������� �� ������������")
            {
                List<RealEstate> listRealEstate = AddDataListRealEstate();
                if (radioButtonAdrressRealEstate.Checked) columnName = "����� ������������";
                else if (radioButtonSurnameRealEstate.Checked) columnName = "������� �����������";
                else if (radioButtonItemRealEstate.Checked) columnName = "������� ���������";
                else if (radioButtonPriceHighRealEstate.Checked) columnName = "��������� ��������� ������";
                else if (radioButtonPriceLowRealEstate.Checked) columnName = "��������� ��������� ������";
                else if (radioButtonTermHighRealEstate.Checked) columnName = "���� ��������� ������";
                else if (radioButtonTermLowRealEstate.Checked) columnName = "���� ��������� ������";
                List<RealEstate> filteredRealEstate = new List<RealEstate>();
                foreach (RealEstate new_realEstate in listRealEstate)
                {
                    if (columnName == "����� ������������")
                    {
                        if (new_realEstate.Address.ToString().Contains(filter))
                            filteredRealEstate.Add(new_realEstate);
                    }
                    else if (columnName == "������� �����������")
                    {
                        if (new_realEstate.Surname.Contains(filter))
                            filteredRealEstate.Add(new_realEstate);
                    }
                    else if (columnName == "������� ���������")
                    {
                        if (new_realEstate.NameOfTheSubjectOfInsurance.Contains(filter))
                            filteredRealEstate.Add(new_realEstate);
                    }
                    else if (columnName == "��������� ��������� ������")
                    {
                        if (double.TryParse(filter, out double filterValue))
                        {
                            if (new_realEstate.InsuranceCost >= filterValue)
                                filteredRealEstate.Add(new_realEstate);
                        }
                    }
                    else if (columnName == "��������� ��������� ������")
                    {
                        if (double.TryParse(filter, out double filterValue))
                        {
                            if (new_realEstate.InsuranceCost <= filterValue)
                                filteredRealEstate.Add(new_realEstate);
                        }
                    }
                    else if (columnName == "���� ��������� ������")
                    {
                        if (int.TryParse(filter, out int filterValue))
                        {
                            if (new_realEstate.TermOfInsurance >= filterValue)
                                filteredRealEstate.Add(new_realEstate);
                        }
                    }
                    else if (columnName == "���� ��������� ������")
                    {
                        if (int.TryParse(filter, out int filterValue))
                        {
                            if (new_realEstate.TermOfInsurance <= filterValue)
                                filteredRealEstate.Add(new_realEstate);
                        }
                    }
                }
                dataGridView3.Rows.Clear();
                foreach (RealEstate new_realEstate in filteredRealEstate)
                {
                    dataGridView3.Rows.Add(new_realEstate.Address, new_realEstate.Surname, new_realEstate.NameOfTheSubjectOfInsurance,
                        new_realEstate.InsuranceCost, new_realEstate.TermOfInsurance);
                }
            }
        }
    }
}