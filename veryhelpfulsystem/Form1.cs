using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryhelpfulsystem
{
    public partial class Form1 : Form
    {
        private News news;
        public Form1()
        {
            InitializeComponent();
            news = new News
                       {
                           new NewsItem{Content = "Казанский федеральный университет приглашает школьников к участию в предметных олимпиадах. Наверняка, в вашей голове назрело множество вопросов по поводу того, получится ли у вас поучаствовать. Мы поможем вам разобраться. Кто участвует? Обучающиеся 8-11 классов образовательных организаций основного общего и среднего общего образования, а также обучающиеся профессиональных образовательных организаций, осваивающих программы среднего общего образования соответствующих ступеней обучения. По каким предметам проводятся олимпиады? -астрономия (9-11 кл.) -биология (9-11 кл.)", Title = "Межрегиональные предметные олимпиады КФУ", ImageURL = @"https://media.kpfu.ru/sites/default/files/2019-01/оли%202.jpg", Date = DateTime.Now},
                           new NewsItem{Content = "Учебно-методический центр тестирования и подготовки к ЕГЭ и ГИА предлагает пройти пробные экзамены в формате ЕГЭ по предметам: математика (профильный уровень), русский язык, обществознание, история, химия, физика, биология, литература, информатика, английский язык.  В формате ОГЭ по математике и русскому языку.Пробные экзамены проводятся по записи в будние дни.", Title = "Открыта регистрация на ПРОБНЫЕ ЭКЗАМЕНЫ в формате ЕГЭ и ОГЭ", ImageURL = @"http://prav-gimn.ru/wp-content/uploads/2020/12/5c173860b7f27095299106.jpg", Date = DateTime.Now},
                           new NewsItem{Content ="В Казанском федеральном университете продолжаются дни открытых дверей. Институты проведут ознакомительные мероприятия для абитуриентов как в традиционном, очном, формате – с посещением учебных корпусов, лабораторий и аудиторий, так и в режиме «онлайн» – через Zoom, «ВКонтакте», YouTube и Microsoft Teams. ", Title = "Приглашаем познакомиться: дни открытых дверей в КФУ с 4 по 10 апреля", ImageURL = @"https://likes.ru/uploads/place/image/7357/super_medium_0498d820d545dfd36102156d47ad58af.jpg", Date = DateTime.Now}
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formavhoda formavhoda = new formavhoda();
            formavhoda.Show();
        }

        private void NewItemPanel_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
