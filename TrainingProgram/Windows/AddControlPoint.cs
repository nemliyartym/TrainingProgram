using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingProgram.Class;

namespace TrainingProgram.Windows
{
    public partial class AddControlPoint : Form
    {
        MainWindow mainWindow = new MainWindow();
        Calculation calculation = new Calculation();
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        WorkWithUsers workWithUsers = new WorkWithUsers();
        AddTpForUser addTpForUser = new AddTpForUser();

        public AddControlPoint(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void AddControlPoint_Load(object sender, EventArgs e)
        {
            addTpForUser.FillListViewStatisticUser(listViewStatisticUser);
        }

        private void buttonAddStatisticUser_Click(object sender, EventArgs e)
        {
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select * from Users where idUsers="+ AddUserWindow.idSelectedUser, 1);
            int age = 0 ;//Convert.ToInt32(DateTime.Now.Year - dateTimePicker.Value.Date.Year);

            double CPwC = calculation.CalculationPowerCondictopn(int.Parse(textBoxPushUps.Text),
                                                        int.Parse(textBoxPullUps.Text),
                                                        int.Parse(textBoxSquts.Text),
                                                        int.Parse(textBoxPress.Text),
                                                        Convert.ToDouble(textBoxRun100.Text));

            double CPhC = calculation.CalculationPhysicalCondition(int.Parse(textBoxPressureUp.Text),
                                                            int.Parse(textBoxPressureDown.Text),
                                                            age,
                                                            int.Parse(textBoxGrowth.Text),
                                                            int.Parse(textBoxWeight.Text),
                                                            int.Parse(textBoxPuls.Text));

            workWithUsers.InsertStatisticsUser(AddUserWindow.idSelectedUser,
                                                           int.Parse(textBoxPuls.Text),
                                                           int.Parse(textBoxPressureUp.Text),
                                                           int.Parse(textBoxPressureDown.Text),
                                                           int.Parse(textBoxGrowth.Text),
                                                           int.Parse(textBoxWeight.Text),
                                                           age,
                                                           int.Parse(textBoxPullUps.Text),
                                                           int.Parse(textBoxPushUps.Text),
                                                           (float)Convert.ToDouble(textBoxRun100.Text),
                                                           int.Parse(textBoxSquts.Text),
                                                           int.Parse(textBoxPullUps.Text),
                                                           (float)CPhC,
                                                           (float)CPwC);
            addTpForUser.FillListViewStatisticUser(listViewStatisticUser);
            addTpForUser.PicterBoxLoad(mainWindow.pictureBoxStatistic,mainWindow.nameColumnFromCoboBox[mainWindow.comboBoxSelectStatistic.SelectedIndex]);
        }

    }
}
