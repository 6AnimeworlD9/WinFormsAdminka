using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.Entity;



namespace WinFormsAdminka
{
    public partial class Form1 : Form
    {
        Context db;
        bool created = false;
        //������������� ����� � ��������� ���� ������ BankDB �� SQL Express
        public Form1()
        {
            InitializeComponent();
            db = new Context();
            loadTf();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           //���������� �������� ������ � ������� ������
           TableMoneyAccounts s1 = new TableMoneyAccounts { Number="1111222233"};
           TableMoneyAccounts s2 = new TableMoneyAccounts { Number = "4444555566" };
           TableMoneyAccounts s3 = new TableMoneyAccounts { Number = "6666777788" };
           db.TMA.AddRange(s1, s2, s3);
           db.SaveChanges();

           //���������� �������� ������ � ������� ����, id ���������� ��������� ������ ����� ��������� ����
           TableCards c1 = new TableCards { IdMonAcc= s1.Id, Number = "2414 3464 2353 6531",Value=256.12 };
           TableCards c2 = new TableCards { IdMonAcc = s1.Id, Number = "6852 3634 4631 3612", Value = 14678.87 };
           TableCards c3 = new TableCards { IdMonAcc = s2.Id, Number = "8743 8348 0202 4781", Value = 153221.41 };
           TableCards c4 = new TableCards { IdMonAcc = s2.Id, Number = "5339 3394 3939 9349", Value = 67231.24 };
           TableCards c5 = new TableCards { IdMonAcc = s3.Id, Number = "5388 0303 0340 0202", Value = 8956.76 };
           db.TC.AddRange(c1,c2,c3,c4,c5);
           db.SaveChanges();

           //���������� �������� ������ � ������� ������� �������� ������������, �������� �������� � ����� � ����� ����� �������
           //�������� ���������� � ��� base64 � ������������ � ��������� �������, � �� �������� ��������� �� ���� ��� nvarchar(max)
           TableHisOfOper h1 = new TableHisOfOper { info= "������� ���.����. ", Image= Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/1.jpg"))};
           TableHisOfOper h2 = new TableHisOfOper { info = "������ �������� � ���������. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/2.jpg")) };
           TableHisOfOper h3 = new TableHisOfOper { info = "���������� ������� ���-�����. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/3.jpg")) };
           TableHisOfOper h4 = new TableHisOfOper { info = "������ ������������� ����������. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForHisOfOper/4.jpg")) };
           db.THO.AddRange(h1, h2, h3, h4);
           db.SaveChanges();

           //���������� �������� ������ � ������� ��������� �������� �������������
           TableFavourites f1 = new TableFavourites { info = "������� ���.����. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/1.jpg")) };
           TableFavourites f2 = new TableFavourites { info = "������ �������. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/2.jpg")) };
           TableFavourites f3 = new TableFavourites { info = "������ ����. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/3.jpg")) };
           TableFavourites f4 = new TableFavourites { info = "������ ������ �� ���-�����. ", Image = Convert.ToBase64String(File.ReadAllBytes("ImageForFavourites/4.jpg")) };
           db.TF.AddRange(f1, f2, f3, f4);
           db.SaveChanges();
        }
        
        //����� ��� ���������� ������� �� ������, � ��������� ������� � ���������� ����������
        private void ReloadDataGrid_Click(object sender, EventArgs e)
        {
            loadTf();
        }
        //������ ����� ��������� � ���������� ������� � ���������� ���������� �������������
        private void loadTf()
        {
            //��������
            db.TF.Load();
            //��������
            dataGridView1.DataSource = db.TF.Local.ToBindingList();
            //����� ����� ������� ������� � ���������� � ������������(���������) ���� � ������ ���� ������� ������� ���� Image
            if (!created)
            {
                dataGridView1.Columns.Remove("Image");
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "Image";
                dataGridView1.Columns.Add(imgColumn);
                created = true;
            }
            //����� ���� �������� �������� ������ � �� � ������������ ����, ��������������� �� � ������������� � ������� � ���������� ��������
            int i = 0;
            foreach (TableFavourites t in db.TF)
            {
                dataGridView1.Rows[i].Cells["Image"].Value = new Bitmap(Base64ToImage(t.Image), new Size(420,800));
                i++;
            }
        }
        //����� ��� �������������� �������� �� ���������� base64 � ��� Image, ������� ��� ����� ���������� ��� ������� ��������
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}