using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.Entity;



namespace WinFormsAdminka
{
    public partial class Form1 : Form
    {
        Context db;
        bool created = false;
        //инициализация формы и контекста базы данных BankDB из SQL Express
        public Form1()
        {
            InitializeComponent();
            db = new Context();
            loadTf();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           //добавление тестовых данных в таблицу счетов
           TableMoneyAccounts s1 = new TableMoneyAccounts { Number="1111222233"};
           TableMoneyAccounts s2 = new TableMoneyAccounts { Number = "4444555566" };
           TableMoneyAccounts s3 = new TableMoneyAccounts { Number = "6666777788" };
           db.TMA.AddRange(s1, s2, s3);
           db.SaveChanges();

           //добавление тестовых данных в таблицу карт, id предыдущих созданных счетов будут привязаны сюда
           TableCards c1 = new TableCards { IdMonAcc= s1.Id, Number = "2414 3464 2353 6531",Value=256.12 };
           TableCards c2 = new TableCards { IdMonAcc = s1.Id, Number = "6852 3634 4631 3612", Value = 14678.87 };
           TableCards c3 = new TableCards { IdMonAcc = s2.Id, Number = "8743 8348 0202 4781", Value = 153221.41 };
           TableCards c4 = new TableCards { IdMonAcc = s2.Id, Number = "5339 3394 3939 9349", Value = 67231.24 };
           TableCards c5 = new TableCards { IdMonAcc = s3.Id, Number = "5388 0303 0340 0202", Value = 8956.76 };
           db.TC.AddRange(c1,c2,c3,c4,c5);
           db.SaveChanges();

           //добавление тестовых данных в таблицу историй операций пользователя, картинки хранятся в папке в корне этого проекта
           //картинки кодируются в тип base64 и записываются в текстовом формате, в БД картинки принимает на себя тип nvarchar(max)
           TableHisOfOper h1 = new TableHisOfOper { info= "Перевод физ.лицу. ", Image= Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/1.jpg"))};
           TableHisOfOper h2 = new TableHisOfOper { info = "Снятие наличных с банкомата. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/2.jpg")) };
           TableHisOfOper h3 = new TableHisOfOper { info = "Пополнение баланса сим-карты. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/3.jpg")) };
           TableHisOfOper h4 = new TableHisOfOper { info = "Оплата общественного транспорта. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/4.jpg")) };
           db.THO.AddRange(h1, h2, h3, h4);
           db.SaveChanges();

           //добавление тестовых данных в таблицу избранных операций пользтователя
           TableFavourites f1 = new TableFavourites { info = "Перевод физ.лицу. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/1.jpg")) };
           TableFavourites f2 = new TableFavourites { info = "Оплата налогов. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/2.jpg")) };
           TableFavourites f3 = new TableFavourites { info = "Оплата газа. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/3.jpg")) };
           TableFavourites f4 = new TableFavourites { info = "Оплата тарифа на сим-карте. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/4.jpg")) };
           db.TF.AddRange(f1, f2, f3, f4);
           db.SaveChanges();
        }
        
        //метод для обновления таблицы на экране, в частности таблицы с избранными операциями
        private void ReloadDataGrid_Click(object sender, EventArgs e)
        {
            loadTf();
        }
        //данный метод загружает и показывает таблицу с избранными операциями пользователей
        private void loadTf()
        {
            //загрузка
            db.TF.Load();
            //привязка
            dataGridView1.DataSource = db.TF.Local.ToBindingList();
            //далее нужно удалить столбец с картинками в кодированном(текстовом) виде и вместо него создать столбец типа Image
            if (!created)
            {
                dataGridView1.Columns["Image"].Visible = false;
                //dataGridView1.Columns.Remove("Image");
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "Images";
                dataGridView1.Columns.Add(imgColumn);
                created = true;
            }
            //после чего получаем картинки ИМЕННО с БД в кодированном виде, преобразовываем их и прорисовываем в ячейках с уменьшиным форматом
            int i = 0;
            foreach (TableFavourites t in db.TF)
            {
                dataGridView1.Rows[i].Cells["Images"].Value = new Bitmap(Base64ToImage(t.Image), new Size(280,540));
                i++;
            }
        }

        //метод для преобразования картинки из текстового base64 в тип Image, который уже можно посмотреть как обычную картинку
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        //метод для обработки события нажатия на кнопку "Добавить"
        //открывает Form2, в которой вводим данные и добавляем этот объект в таблицу, сохраняем в БД
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            DialogResult result = add.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TableFavourites tf = new TableFavourites { info = add.richTextBox1.Text, Image = Convert.ToBase64String(File.ReadAllBytes(add.path)) };
            db.TF.Add(tf);
            db.SaveChanges();

            MessageBox.Show("Успешно добавлено.");
            loadTf();
        }

        //метод для обработки события нажатия на кнопку "Изменить"
        //открывает Form2, в которой выводятся данные выбранного объекта, их можно переписать, сохраняем в БД
        private void UpdBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[1, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                TableFavourites tf = db.TF.Find(id);

                Form2 update = new Form2();

                update.idLbl.Text = tf.Id.ToString();
                update.richTextBox1.Text = tf.info;


                DialogResult result = update.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                tf.info = update.richTextBox1.Text;
                if (update.path != "")
                    tf.Image = Convert.ToBase64String(File.ReadAllBytes(update.path));

                db.SaveChanges();
                MessageBox.Show("Успешно обновлено.");
                loadTf();
            }
        }

        //метод для обработки события нажатия на кнопку "Удалить"
        //удаляет выбранный объект из БД
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[1, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                TableFavourites tf = db.TF.Find(id);
                db.TF.Remove(tf);
                
                db.SaveChanges();
                MessageBox.Show("Успешно удалено.");
                loadTf();
            }
        }
    }
}