using System.ComponentModel.Design;
using System.Data; // ado.net kütüphanesi
using System.Data.Common;
using System.Data.SqlClient;// ado.net kütüphanesi
namespace WindowsFormsAppAdonet
{
    public class KategoriDAL : OrtakDal
    {
        public int Add(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("insert into Categories values(@KategoriAdi, @Durum)", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            var sonuc = command.ExecuteNonQuery();// Bu satır insert komutunun çalıştırılarak verilerin verittabanına işlenmesini sağlar
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Update(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("update Categories set KategoriAdi=@KategoriAdi, Durum=@Durum where Id=@Id", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            command.Parameters.AddWithValue("@Id", kategori.Id);
            var sonuc = command.ExecuteNonQuery();// Bu satır insert komutunun çalıştırılarak verilerin verittabanına işlenmesini sağlar
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("delete from Categories where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            int sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
    }
}