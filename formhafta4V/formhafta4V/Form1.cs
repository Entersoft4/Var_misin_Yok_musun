namespace formhafta4V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] para = new int[20] {10,15,20,100,250,500,1000,5000,10000,25000,
        50000,75000,100000,125000,250000,500000,600000,750000,800000,1000000};
        int[] kutu = new int[20];
        Random r = new Random();
        int p, sayac = 0, x;
        int teklif, toplam = 4291895, kalan;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kutu.Length; i++)
            {
                kutu[i] = i;
            }
            for (int i = 0; i < para.Length; i++)
            {
                p = r.Next(0, 20);
                if (para[p] != 0)
                {
                    kutu[i] = para[p];
                    para[p] = 0;
                }
                else
                {
                    i--;
                }
            }
            l1.Text = "Lütfen 1 kutu seçiniz.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 1 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                l3.Text = label1.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button1.Text = kutu[0] + " TL";
                toplam -= kutu[0];
                button1.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[0] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 2 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = false;
                l3.Text = label2.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button2.Text = kutu[1] + " TL";
                toplam -= kutu[1];
                button2.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[1] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 3 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3.Enabled = false;
                l3.Text = label3.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button3.Text = kutu[2] + " TL";
                toplam -= kutu[2];
                button3.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[2] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 4 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button4.Enabled = false;
                l3.Text = label4.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button4.Text = kutu[3] + " TL";
                toplam -= kutu[3];
                button4.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[3] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 5 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button5.Enabled = false;
                l3.Text = label5.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button5.Text = kutu[4] + " TL";
                toplam -= kutu[4];
                button5.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[4] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 6 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button6.Enabled = false;
                l3.Text = label6.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button6.Text = kutu[5] + " TL";
                toplam -= kutu[5];
                button6.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[5] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 7 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button7.Enabled = false;
                l3.Text = label7.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button7.Text = kutu[6] + " TL";
                toplam -= kutu[6];
                button7.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[6] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 8 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button8.Enabled = false;
                l3.Text = label8.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button8.Text = kutu[7] + " TL";
                toplam -= kutu[7];
                button8.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[7] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 9 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button9.Enabled = false;
                l3.Text = label9.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button9.Text = kutu[8] + " TL";
                toplam -= kutu[8];
                button9.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[8] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 10 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button10.Enabled = false;
                l3.Text = label10.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button10.Text = kutu[9] + " TL";
                toplam -= kutu[9];
                button10.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[9] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 11 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = false;
                l3.Text = label11.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button11.Text = kutu[10] + " TL";
                toplam -= kutu[10];
                button11.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[10] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 12 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button12.Enabled = false;
                l3.Text = label12.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button12.Text = kutu[11] + " TL";
                toplam -= kutu[11];
                button12.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[11] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 13 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button13.Enabled = false;
                l3.Text = label13.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button13.Text = kutu[12] + " TL";
                toplam -= kutu[12];
                button13.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[12] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 14 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button14.Enabled = false;
                l3.Text = label14.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button14.Text = kutu[13] + " TL";
                toplam -= kutu[13];
                button14.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[13] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 15 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button15.Enabled = false;
                l3.Text = label15.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button15.Text = kutu[14] + " TL";
                toplam -= kutu[14];
                button15.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[14] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 16 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button16.Enabled = false;
                l3.Text = label16.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button16.Text = kutu[15] + " TL";
                toplam -= kutu[15];
                button16.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[15] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 17 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button17.Enabled = false;
                l3.Text = label17.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button17.Text = kutu[16] + " TL";
                toplam -= kutu[16];
                button17.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[16] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 18 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button18.Enabled = false;
                l3.Text = label18.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button18.Text = kutu[17] + " TL";
                toplam -= kutu[17];
                button18.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[17] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 19 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button19.Enabled = false;
                l3.Text = label19.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button19.Text = kutu[18] + " TL";
                toplam -= kutu[18];
                button19.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[18] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KUTU 20 mühürlendi.", "SEÇÝLEN KUTU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button20.Enabled = false;
                l3.Text = label20.Text;
                sayac++;
                l1.Text = "Lütfen 2 tane kutu açýnýz.";
            }
            else
            {
                button20.Text = kutu[19] + " TL";
                toplam -= kutu[19];
                button20.Enabled = false;
                sayac++;
                if ((sayac % 2) == 1)
                {
                    if (sayac == 19)
                    {
                        DialogResult yeni2 = new DialogResult();
                        kalan = 5;
                        teklif = toplam * kalan;
                        yeni2 = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni2 == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        l1.Text = "Lütfen son kutuyu veya kendi kutunuzu seçiniz.";
                    }
                    else
                    {
                        DialogResult yeni = new DialogResult();
                        kalan = 20 - sayac;
                        teklif = toplam / kalan;
                        yeni = MessageBox.Show(teklif + " TL. Var mýsýn? (YES), Yok musun? (NO)",
                        "HAMDÝ BEY'ÝN TEKLÝFÝ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yeni == DialogResult.Yes)
                        {
                            MessageBox.Show(teklif + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
                if (sayac == 20)
                {
                    MessageBox.Show(kutu[19] + " TL kazandýnýz. Tebrikler!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (sayac == 19)
            {
                x = Convert.ToInt32(l3.Text);
                b2.Text = kutu[x - 1] + " TL";
                MessageBox.Show(kutu[x - 1] + " TL kazandýnýz. TEBRÝKLER!!!", "WÝN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}