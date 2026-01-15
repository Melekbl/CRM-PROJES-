using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Proje1.DAL;
using CRM.Proje1.Domain;
using MySql.Data.MySqlClient;

namespace CRM.Proje1.DAL
{
    public class HizmetDAL
    {
        public List<Hizmet> TumHizmetler()
        {
            var liste = new List<Hizmet>();

            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "SELECT * FROM Hizmetler";

                using (var cmd = new MySqlCommand(sql, con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add(new Hizmet
                        {
                            HizmetId = Convert.ToInt32(dr["HizmetId"]),
                            HizmetAdi = dr["HizmetAdi"].ToString(),
                            Aciklama = dr["Aciklama"].ToString(),
                            Ucret = Convert.ToDecimal(dr["Ucret"])
                        });
                    }
                }
            }
            return liste;
        }

        public void HizmetEkle(Hizmet h)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "INSERT INTO Hizmetler (HizmetAdi, Aciklama, Ucret) VALUES (@ad,@ac,@u)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ad", h.HizmetAdi);
                    cmd.Parameters.AddWithValue("@ac", h.Aciklama);
                    cmd.Parameters.AddWithValue("@u", h.Ucret);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void HizmetGuncelle(Hizmet h)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "UPDATE Hizmetler SET HizmetAdi=@ad, Aciklama=@ac, Ucret=@u WHERE HizmetId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ad", h.HizmetAdi);
                    cmd.Parameters.AddWithValue("@ac", h.Aciklama);
                    cmd.Parameters.AddWithValue("@u", h.Ucret);
                    cmd.Parameters.AddWithValue("@id", h.HizmetId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void HizmetSil(int HizmetId)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "DELETE FROM Hizmetler WHERE HizmetId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", HizmetId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
