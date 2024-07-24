using System.Data; // ado.net kütüphanesi
using System.Data.Common;
using System.Data.SqlClient; // ado.net kütüphanesi

namespace WindowsFormsAppAdonet
{
    public class OrtakDal
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; database=UrunYonetimiAdoNet; Integrated security=True"); // sql server veritabanına baglantı kurmayı saglayan nesnemiz
        internal void ConnectionKontrol()//Veritabanı baglantısının acık olup olmadıgını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public DataTable GetAllDataTable(string sqlSorgu)
        {
            ConnectionKontrol(); //Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand(sqlSorgu, _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu olusturduk
            dataTable.Load(reader);//DATA TABLOYA veritabanından çektiğimiz kayıtları yukledik
            reader.Close();//VERİ OKUYUCUYU KAPATTIK
            _connection.Close();
            return dataTable;//KAYITLARIN YÜKLENDİĞİ DATA TABLOYU GERİYE DÖNDÜRDÜK
        }
    }
}
