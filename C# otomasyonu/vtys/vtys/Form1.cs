using Npgsql;
using System.Data;

namespace vtys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=okullDB;user Id=postgres; password=12345");
        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bolumler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from dersler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from fakulteler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ogrenci_sinav";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ogrenciler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ogretmenler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from okul";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sinavlar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into bolumler(bolum_id,bolum_adi,fakulte_id) values(@p1,@p2,@p3)", baglanti);
                komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                komut1.Parameters.AddWithValue("@p2", textBox2.Text);
                komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox3.Text));
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
{
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into dersler(ders_id,ders_adi,bolum_id,ogretmen_id) values(@p1,@p2,@p3,@p4)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox6.Text));
                komut2.Parameters.AddWithValue("@p2", textBox5.Text);
                komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox4.Text));
                komut2.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox7.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try{
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into fakulteler(fakulte_id,fakulte_adi,okul_id) values(@p1,@p2,@p3)", baglanti);
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox10.Text));
            komut2.Parameters.AddWithValue("@p2", textBox9.Text);
            komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox8.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
{
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into ogrenci_sinav(ogrenci_id,sinav_id,notu) values(@p1,@p2,@p3)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox13.Text));
                komut2.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox12.Text));
                komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox11.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into ogrenciler(ogrenci_id,ad,soyad,dogum_tarihi,bolum_id) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox17.Text));
                komut2.Parameters.AddWithValue("@p2", textBox16.Text);
                komut2.Parameters.AddWithValue("@p3", textBox15.Text);
                komut2.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
                komut2.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox18.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into ogretmenler(ogretmen_id,ad,soyad,ise_baslama_tarihi,bolum_id) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox23.Text));
                komut2.Parameters.AddWithValue("@p2", textBox22.Text);
                komut2.Parameters.AddWithValue("@p3", textBox21.Text);
                komut2.Parameters.AddWithValue("@p4", dateTimePicker2.Value);
                komut2.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox19.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into okul(okul_id,okul_adi,adres) values(@p1,@p2,@p3)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox26.Text));
                komut2.Parameters.AddWithValue("@p2", textBox25.Text);
                komut2.Parameters.AddWithValue("@p3", textBox24.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into sinavlar(sinav_id,sinav_adi,ders_id,sinav_tarihi) values(@p1,@p2,@p3,@p4)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox30.Text));
                komut2.Parameters.AddWithValue("@p2", textBox29.Text);
                komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox28.Text));
                komut2.Parameters.AddWithValue("@p4", dateTimePicker3.Value);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme isleminiz basari ile tamamlandi,", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From bolumler where bolum_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From dersler where ders_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox6.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From fakulteler where fakulte_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox10.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("DELETE FROM ogrenci_sinav WHERE ogrenci_id = @p1 AND sinav_id = @p2", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox13.Text));
                komut3.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox12.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From ogrenciler where ogrenci_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox17.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From ogretmenler where ogretmen_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox23.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From okul where okul_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox26.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete From sinavlar where sinav_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox30.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme isleminiz basari ile tamamlandi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update bolumler set bolum_adi = @p2,fakulte_id=@p3 where bolum_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                komut4.Parameters.AddWithValue("@p2", textBox2.Text);
                komut4.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox3.Text));
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update dersler set ders_adi = @p2,bolum_id=@p3,ogretmen_id=@p4 where ders_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox6.Text));
                komut4.Parameters.AddWithValue("@p2", textBox5.Text);
                komut4.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox4.Text));
                komut4.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox7.Text));
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update fakulteler set fakulte_adi = @p2,okul_id=@p3 where fakulte_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox10.Text));
                komut4.Parameters.AddWithValue("@p2", textBox9.Text);
                komut4.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox8.Text));
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("UPDATE ogrenci_sinav SET notu=@p3 WHERE ogrenci_id=@p1 AND sinav_id=@p2", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox13.Text));
                komut4.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox12.Text));
                komut4.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox11.Text));
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update ogrenciler set bolum_id=@p4, ad=@p2,soyad=@p3,dogum_tarihi=@p5 where ogrenci_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox17.Text));
                komut4.Parameters.AddWithValue("@p2", textBox16.Text);
                komut4.Parameters.AddWithValue("@p3", textBox15.Text);
                komut4.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
                komut4.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox18.Text));
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update ogretmenler set ad = @p2,soyad=@p3, ise_baslama_tarihi=@p4,bolum_id=@p5 where ogretmen_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox23.Text));
                komut4.Parameters.AddWithValue("@p2", textBox22.Text);
                komut4.Parameters.AddWithValue("@p3", textBox21.Text);
                komut4.Parameters.AddWithValue("@p4", dateTimePicker2.Value);
                komut4.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox19.Text));
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update okul set okul_adi = @p2,adres=@p3 where okul_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox26.Text));
                komut4.Parameters.AddWithValue("@p2", textBox25.Text);
                komut4.Parameters.AddWithValue("@p3", textBox24.Text);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update sinavlar set sinav_adi = @p2,ders_id=@p3,sinav_tarihi=@p4 where sinav_id=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox30.Text));
                komut4.Parameters.AddWithValue("@p2", textBox29.Text);
                komut4.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox28.Text));
                komut4.Parameters.AddWithValue("@p4", dateTimePicker3.Value);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme iþleminiz baþarý ile tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
