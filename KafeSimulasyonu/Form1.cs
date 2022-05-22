using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSimulasyonu
{
    public partial class Form1 : Form
    {
        Musteri m = new Musteri();
        Calisan c = new Calisan();
        
        Timer timer = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();

        List<Button> musteriler = new List<Button>();
        List<Menu> menuler = new List<Menu>()

        {
            new Menu{Ad = "Flat White", HazırlanmaSuresi= 3 },
            new Menu{Ad = "Caffe Latte", HazırlanmaSuresi= 4 },
            new Menu{Ad = "Filtre Kahve", HazırlanmaSuresi= 2 },
            new Menu{Ad = "Cold Brew", HazırlanmaSuresi= 3 },
            new Menu{Ad = "Cool Lime", HazırlanmaSuresi= 2 },
            new Menu{Ad = "Berry Hibiscus", HazırlanmaSuresi= 4 },
            new Menu{Ad = "Caramel Frappuccino", HazırlanmaSuresi= 3 },
            new Menu{Ad = "Hot Chocolate", HazırlanmaSuresi= 2 },
            new Menu{Ad = "White Hot Chocolate", HazırlanmaSuresi= 4 },
            new Menu{Ad = "Chai Tea Latte", HazırlanmaSuresi= 3 },

        };

        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer2.Tick += Timer2_Tick;
            timer3.Tick += Timer3_Tick;

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            c.barista3MusaitMi = true;
            musteriler.RemoveAt(0);
            panel1.Controls.RemoveAt(4);
            CalısanMusaitlikDurumu();
            m.musteriDurumu--;
            c.kasaMusaitMi = true;
            return;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            c.barista2MusaitMi = true;
            musteriler.RemoveAt(0);
            panel1.Controls.RemoveAt(4);
            CalısanMusaitlikDurumu();
            m.musteriDurumu--;
            c.kasaMusaitMi = true;
            return;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            c.barista1MusaitMi = true;
            musteriler.RemoveAt(0);
            panel1.Controls.RemoveAt(4);
            CalısanMusaitlikDurumu();
            m.musteriDurumu--;
            c.kasaMusaitMi = true;
            return;

        }

        public void MenuleriOlustur()
        {
            foreach (var item in menuler)
            {
                cbMenuler.Items.Add(item);
            }
        }

        
        public void MusteriOlustur()
        {
            Button musteri = new Button();
            musteri.Size = new Size(55, 60);
            musteri.Location = new Point(490, m.konumY);
            Image musteriE = Properties.Resources.person3;
            musteri.BackgroundImage = musteriE;
            musteri.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(musteri);
            m.konumY += 65;
            musteriler.Add(musteri);
        }

        public void CalısanMusaitlikDurumu()
        {
            if (c.kasaMusaitMi)
            {
                btnKasa.BackgroundImage = Properties.Resources.musaitE;
                btnKasa.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                btnKasa.BackgroundImage = Properties.Resources.mesgulE;
                btnKasa.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (c.barista1MusaitMi)
            {
                btnBarista1.BackgroundImage = Properties.Resources.musaitK;
                btnBarista1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                btnBarista1.BackgroundImage = Properties.Resources.mesgulK;
                btnBarista1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (c.barista2MusaitMi)
            {
                btnBarista2.BackgroundImage = Properties.Resources.musaitE;
                btnBarista2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                btnBarista2.BackgroundImage = Properties.Resources.mesgulE;
                btnBarista2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (c.barista3MusaitMi)
            {
                btnBarista3.BackgroundImage = Properties.Resources.musaitE;
                btnBarista3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                btnBarista3.BackgroundImage = Properties.Resources.mesgulE;
                btnBarista3.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuleriOlustur();
            CalısanMusaitlikDurumu();
        }

        private void btnMusteriOlustur_Click(object sender, EventArgs e)
        {
            m.musteriDurumu++;
            if (m.musteriDurumu >= 6)
            {
                MessageBox.Show("Şuanda sıra dolu! Müşteri alamazsınız!");
            }
            else
            {
                MusteriOlustur();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            musteriler.RemoveAt(0);
        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (c.barista1MusaitMi==false && c.barista2MusaitMi==false && c.barista3MusaitMi==false)
            {
                c.kasaMusaitMi = false;
                CalısanMusaitlikDurumu();
                MessageBox.Show("Tüm Baristalar Şuanda Sipariş Hazırlıyor! Lütfen Bekleyiniz!");
            }

            for (int i = 0; i < musteriler.Count; i++)
            {
                if (musteriler[i].Location == new Point(m.konumX, 210))
                {
                    musteriler[i].Location = new Point(m.konumX - 90, 210);
                    for (int j = 1; j < musteriler.Count; j++)
                    {
                        musteriler[j].Location = new Point(m.konumX, m.konumY1);
                        m.konumY1 = m.konumY1 + 65;
                    }
                    c.barista1MusaitMi = false;
                    timer.Interval = 2000;
                    timer.Start();
                    m.konumY1 = 210;
                    m.musteriDurumu--;
                    m.konumY = m.konumY - 65;
                    CalısanMusaitlikDurumu();
                    return;
                }
                if (musteriler[i].Location == new Point(m.konumX - 90, 210))
                {
                    musteriler[i].Location = new Point(m.konumX - 180, 210);
                    musteriler[i + 1].Location = new Point(m.konumX - 90, 210);
                    for (int j = 2; j < musteriler.Count; j++)
                    {
                        musteriler[j].Location = new Point(m.konumX, m.konumY1);
                        m.konumY1 = m.konumY1 + 65;
                    }
                    c.barista2MusaitMi = false;
                    timer2.Interval = 3000;
                    timer2.Start();
                    m.konumY1 = 210;
                    m.musteriDurumu--;
                    m.konumY = m.konumY - 65;
                    CalısanMusaitlikDurumu();
                    return;
                }
                if (musteriler[i].Location == new Point(m.konumX - 180, 210))
                {
                    musteriler[i].Location = new Point(m.konumX - 270, 210);
                    musteriler[i + 2].Location = new Point(m.konumX - 180, 210);
                    for (int j = 3; j < musteriler.Count; j++)
                    {
                        musteriler[j].Location = new Point(m.konumX, m.konumY1);
                        m.konumY1 = m.konumY1 + 65;
                    }
                    c.barista3MusaitMi = false;
                    timer3.Interval = 4000;
                    timer3.Start();
                    m.konumY1 = 210;
                    m.musteriDurumu--;
                    m.konumY = m.konumY - 65;
                    CalısanMusaitlikDurumu();
                    return;
                }
            }
        }
    }
}
