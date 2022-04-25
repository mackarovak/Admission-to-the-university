using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryhelpfulsystem
{
    public partial class MainForm : Form
    {
        private News news;
        DataBaseHelper dataBase;
        List<PeopleFromPrikaz> peoplefromprikazs = new List<PeopleFromPrikaz>();
        public MainForm()
        {
            InitializeComponent();
            news = new News
                       {
                           new NewsItem{Content = "Казанский федеральный университет приглашает школьников к участию в предметных олимпиадах. Наверняка, в вашей голове назрело множество вопросов по поводу того, получится ли у вас поучаствовать. Мы поможем вам разобраться. Кто участвует? Обучающиеся 8-11 классов образовательных организаций основного общего и среднего общего образования, а также обучающиеся профессиональных образовательных организаций, осваивающих программы среднего общего образования соответствующих ступеней обучения. По каким предметам проводятся олимпиады? -астрономия (9-11 кл.) -биология (9-11 кл.)", Title = "Межрегиональные предметные олимпиады КФУ", ImageURL = @"https://media.kpfu.ru/sites/default/files/2019-01/оли%202.jpg", Date = DateTime.Now},
                           new NewsItem{Content = "Учебно-методический центр тестирования и подготовки к ЕГЭ и ГИА предлагает пройти пробные экзамены в формате ЕГЭ по предметам: математика (профильный уровень), русский язык, обществознание, история, химия, физика, биология, литература, информатика, английский язык.  В формате ОГЭ по математике и русскому языку.Пробные экзамены проводятся по записи в будние дни.", Title = "Открыта регистрация на ПРОБНЫЕ ЭКЗАМЕНЫ в формате ЕГЭ и ОГЭ", ImageURL = @"http://prav-gimn.ru/wp-content/uploads/2020/12/5c173860b7f27095299106.jpg", Date = DateTime.Now},
                           new NewsItem{Content ="В Казанском федеральном университете продолжаются дни открытых дверей. Институты проведут ознакомительные мероприятия для абитуриентов как в традиционном, очном, формате – с посещением учебных корпусов, лабораторий и аудиторий, так и в режиме «онлайн» – через Zoom, «ВКонтакте», YouTube и Microsoft Teams. ", Title = "Приглашаем познакомиться: дни открытых дверей в КФУ с 4 по 10 апреля", ImageURL = @"https://i.ytimg.com/vi/NOJqeTyZgx4/maxresdefault.jpg", Date = DateTime.Now}
                       };

            Build();
        }

        private void Build()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in news)
                new NewItemPanel { Parent = flowLayoutPanel1 }.Build(item);
        }

        private void tg_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/KPFU_AbiturBot");
        }

        private void vk_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/kazan_federal_university");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formavhoda formavhoda = new formavhoda();
            formavhoda.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var linkAddress = @"https://kpfu.ru/department-of-security/bezopasnost-universiteta/antiterroristicheskaya-deyatelnost";
            System.Diagnostics.Process.Start(linkAddress);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var linkAddress = @"https://kpfu.ru/department-of-security/bezopasnost-universiteta/telefon-doveriya";
            System.Diagnostics.Process.Start(linkAddress);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var linkAddress = @"https://kpfu.ru/department-of-security/bezopasnost-universiteta/dezhurno-dispetcherskoj-sluzhba";
            System.Diagnostics.Process.Start(linkAddress);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var linkAddress = @"https://kpfu.ru/department-of-security/bezopasnost-universiteta/profilaktika-narkomanii-v-molodezhnoj-srede";
            System.Diagnostics.Process.Start(linkAddress);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpfu.ru/portal/docs/F1344839694/Prikaz.Minobrnauki.Rossii.ot.18.marta.2022g..._10_02_0228.o.naznachenii.ispolnyayushhim.obyazannosti.rektora.Tayurskogo.D.A..pdf");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpfu.ru/portal/docs/F1751926221/Ustav.KFU_2018.pdf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpfu.ru/portal/docs/F_507185085/Prikaz.MO_14.02.2020__220.pdf");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpfu.ru/portal/docs/F255911047/09.12.2016_01_06_1284_Gafurov_I.R._Halilova_A.N.pdf");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpfu.ru/portal/docs/F394227958/Prikaz.ot.29.12.2021._.1577.pdf");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kpfu.ru/portal/docs/F2042699633/Licenziya.na.OD.01.02.21.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataBase = new DataBaseHelper();
            peoplefromprikazs = dataBase.ZapisPrikaza();
            using (StreamWriter streamWriter = new StreamWriter("Приказ.txt"))
            {
                for (int i = 0; i < peoplefromprikazs.Count; streamWriter.Write((i == 0 ? string.Empty : " ") + peoplefromprikazs[i++].ToString())) ;
                streamWriter.WriteLine(string.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/museum-of-history");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/istoriya-universiteta/rektory-universiteta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/kazanskomu-universitetu-215");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/istoriya-universiteta/tradicii-kazanskogo-universiteta");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/missiya-kazanskogo-universiteta");
        }

        private void structure_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/struct");
        }

        private void facts_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/cifry-i-fakty");
        }

        private void priem_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/internet-priemnaya");
        }

        private void workers_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/staff/sotrudniki-kfu");
        }

        private void maps_Click(object sender, EventArgs e)
        {
            Process.Start("https://kpfu.ru/about_university/karta-vseh-obektov");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://e.mail.ru/compose/");

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://admissions.kpfu.ru");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/learning/distance-learning");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/#login");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/universiade-village/hostel/about");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/academic%20mobility/grants/about");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/about-student-club/club/about");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/#login");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/work/vacancies-rus");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://students.kpfu.ru/#login");
        }
    }
}