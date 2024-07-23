using System;
using System.Collections.Generic;
using System.Linq;
using System.Data; // ado.net kütüphanesi
using System.Data.SqlClient; // ado.net kütüphanesi

namespace WindowsFormsAppAdonet
{
    internal class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; database=UrunYonetimiAdoNet; Integrated security=True"); // sql server veritabanına baglantı kurmayı saglayan nesnemiz
    private void ConnectionKontrol()//Veritabanı baglantısının acık olup olmadıgını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product> GetAll()
        { 
            List<Product>products = new List<Product>();
            ConnectionKontrol(); // veritabanı bağlantısını aç
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]),
                    Durum = Convert.ToBoolean(reader["Durum"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            command.Dispose(); //komutu yok et , mesmeyı yok eder
            return products;
        }
        public DataTable GetAllDataTable()
        {
            ConnectionKontrol(); //Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from products", _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu olusturduk
            dataTable.Load(reader);//DATA TABLOYA veritabanından çektiğimiz kayıtları yukledik
            reader.Close();//VERİ OKUYUCUYU KAPATTIK
            _connection.Close();
            return dataTable;//KAYITLARIN YÜKLENDİĞİ DATA TABLOYU GERİYE DÖNDÜRDÜK
        }
        public DataTable GetAllDataTable(string kelime)
        {
            ConnectionKontrol(); //Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from products where urunadi like @kelime", _connection);//veritabanına sorgumuzu gönderdik
            komut.Parameters.AddWithValue("@kelime", "%"+ kelime + "%");
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu olusturduk
            dataTable.Load(reader);//DATA TABLOYA veritabanından çektiğimiz kayıtları yukledik
            reader.Close();//VERİ OKUYUCUYU KAPATTIK
            _connection.Close();
            return dataTable;//KAYITLARIN YÜKLENDİĞİ DATA TABLOYU GERİYE DÖNDÜRDÜK
        }
        public int Add(Product product)
        {
            int islemSonucu = 0;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@UrunAdi,@UrunFiyati,@StokMiktari,@Durum)", _connection );
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.Parameters.AddWithValue("@Durum", product.Durum);
            islemSonucu = command.ExecuteNonQuery(); // ExecuteNonQuery metodu bize sql de etkilenen kayıt sayısını döner
            command.Dispose();
            _connection.Close();
            return islemSonucu;
        }
        public Product Get(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Select top(1) * from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();
            Product product = new Product();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    product.Id = Convert.ToInt32(reader["Id"]);
                    product.UrunAdi = reader["UrunAdi"].ToString();
                    product.StokMiktari = Convert.ToInt32(reader["StokMiktari"]);
                    product.UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]);
                    product.Durum = Convert.ToBoolean(reader["Durum"]);
                }
            }
            else product = null;
            reader.Close();
            _connection.Close ();
            return product;
        }
        public int Update(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
               "Update Products set UrunAdi=@Uadi, UrunFiyati=@UrunFiyati, StokMiktari=@StokMiktari, Durum=@Durum where Id=id", _connection );
            command.Parameters.AddWithValue("@Uadi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", Convert.ToDecimal(product.UrunFiyati));
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.Parameters.AddWithValue("@Durum", product.Durum);
            command.Parameters.AddWithValue("@id", product.Id);
            int sonuc = command.ExecuteNonQuery();
            _connection.Close();
            return sonuc;
        }
        public int Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            int sonuc = command.ExecuteNonQuery();
            _connection.Close();
            return sonuc;
        }

    }
}
