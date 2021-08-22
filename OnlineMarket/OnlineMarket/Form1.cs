using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace OnlineStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Product> myproducts = new List<Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.name = textBox1.Text;
                product.price = Convert.ToInt32(textBox2.Text);
                product.description = textBox3.Text;
                if (MessageBox.Show("Ürün fotoğrafını güncellemek istiyor musunuz?", "Fotoğraf", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Load(openFileDialog1.FileName);
                        product.picture.filename = openFileDialog1.FileName;
                        product.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product.picture.filename);
                    }
                }
                else
                {
                        product.picture.filename = "transparan.jpg";
                        product.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product.picture.filename);
                }
                myproducts.Add(product);
                listBox1.Items.Add(product.name);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    int i = myproducts.Count - 1;
                    while (i >= 0)
                    {
                        if (myproducts[i].name == listBox1.SelectedItem.ToString())
                        {
                            myproducts.RemoveAt(i);
                            listBox1.Items.Remove(listBox1.SelectedItem);
                            break;
                        }
                        i--;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            if (listBox1.SelectedItem != null)
            {
                int i = myproducts.Count - 1;
                while (i >= 0)
                {
                    if (myproducts[i].name == listBox1.SelectedItem.ToString())
                    {
                        myproducts[i].name = textBox1.Text;
                        myproducts[i].price = Convert.ToInt32(textBox2.Text);
                        myproducts[i].description = textBox3.Text;

                        if (MessageBox.Show("Ürün fotoğrafını güncellemek istiyor musunuz?", "Fotoğraf", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                pictureBox1.Load(openFileDialog1.FileName);
                                myproducts[i].picture.filename = openFileDialog1.FileName;
                                myproducts[i].picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", myproducts[i].picture.filename);
                            }
                        }
                        else
                        {
                                if (myproducts[i].picture.path != null)
                                {
                                    myproducts[i].picture.filename = "transparan.jpg";
                                    myproducts[i].picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", myproducts[i].picture.filename);
                                }
                            }

                            listBox1.Items[listBox1.SelectedIndex] = myproducts[i].name;
                        break;
                    }
                    i--;
                }
            }
        }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (listBox1.SelectedItem != null)
            {
                int i = myproducts.Count - 1;
                while (i >= 0)
                {
                    if (myproducts[i].name == listBox1.SelectedItem.ToString())
                    {
                        label9.Text = myproducts[i].name;
                        label10.Text = Convert.ToString(myproducts[i].price);
                        label11.Text = myproducts[i].description;
                            if (myproducts[i].picture.path != null)
                            {
                                System.Drawing.Image img = System.Drawing.Image.FromFile(myproducts[i].picture.path);
                                pictureBox1.Image = img;
                            }
                        break;
                    }
                    i--;
                }
            }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = "Portakal";
            product.price = 10;
            product.description = "Organik Portakal";
            product.picture.filename = "portakal.jpg";
            product.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product.picture.filename);
            myproducts.Add(product);
            listBox1.Items.Add(product.name);

            Product product2 = new Product();
            product2.name = "Soğan";
            product2.price = 3;
            product2.description = "Organik Soğan";
            product2.picture.filename = "soğan.jpg";
            product2.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product2.picture.filename);
            myproducts.Add(product2);
            listBox1.Items.Add(product2.name);

            Product product3 = new Product();
            product3.name = "Ananas";
            product3.price = 22;
            product3.description = "Organik Ananas";
            product3.picture.filename = "ananas.jpg";
            product3.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product3.picture.filename);
            myproducts.Add(product3);
            listBox1.Items.Add(product3.name);

            Product product4 = new Product();
            product4.name = "Havuç";
            product4.price = 8;
            product4.description = "Organik Havuç";
            product4.picture.filename = "havuç.jpg";
            product4.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product4.picture.filename);
            myproducts.Add(product4);
            listBox1.Items.Add(product4.name);

            Product product5 = new Product();
            product5.name = "Armut";
            product5.price = 8;
            product5.description = "Organik Armut";
            product5.picture.filename = "armut.jpg";
            product5.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product5.picture.filename);
            myproducts.Add(product5);
            listBox1.Items.Add(product5.name);

            Product product6 = new Product();
            product6.name = "Biber";
            product6.price = 5;
            product6.description = "Organik Biber";
            product6.picture.filename = "biber.jpg";
            product6.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product6.picture.filename);
            myproducts.Add(product6);
            listBox1.Items.Add(product6.name);

            Product product7= new Product();
            product7.name = "Patates";
            product7.price = 3;
            product7.description = "Organik Patates";
            product7.picture.filename = "patates.jpg";
            product7.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product7.picture.filename);
            myproducts.Add(product7);
            listBox1.Items.Add(product7.name);

            Product product8 = new Product();
            product8.name = "Elma";
            product8.price = 7;
            product8.description = "Organik Elma";
            product8.picture.filename = "elma.jpg";
            product8.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product8.picture.filename);
            myproducts.Add(product8);
            listBox1.Items.Add(product8.name);

            Product product9 = new Product();
            product9.name = "Maydanoz";
            product9.price = 2;
            product9.description = "Organik Maydanoz";
            product9.picture.filename = "maydanoz.jpg";
            product9.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product9.picture.filename);
            myproducts.Add(product9);
            listBox1.Items.Add(product9.name);

            Product product10 = new Product();
            product10.name = "Domates";
            product10.price = 4;
            product10.description = "Organik Domates";
            product10.picture.filename = "domates.jpg";
            product10.picture.path = Path.Combine(Environment.CurrentDirectory, @"Data\", product10.picture.filename);
            myproducts.Add(product10);
            listBox1.Items.Add(product10.name);
        }
    }
}
