using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Banco banco;
        FileStream archivo;
        StreamReader sr;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            tbInformar.Text = $"{"Numero de Cuenta",20}{"|"}{"Nombre",20}{"|"}{"Saldo",10}{Environment.NewLine}";
            tbInformar.Text += $"{"".PadRight(20,'-')}{"|"}{"".PadRight(20,'-')}{"|"}{"".PadRight(10,'-')}{Environment.NewLine}";
            for (int i = 0; i < banco.CantidadCuentas; i++)
            {
                Cuenta c = banco[i];
                tbInformar.Text += $"{c.Titular.DNI, 20}{"|"}{c.Titular.Nombre, 20}{"|"}{c.Saldo, 10}{Environment.NewLine}";
            }
        }

        private void btnImportarCuentas_Click(object sender, EventArgs e)
        {
            string name;
            string[] campos;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int numero = 0, dni = 0;
                double saldo = 0;
                name = openFileDialog1.FileName;

                archivo = new FileStream(name, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);
                while (!sr.EndOfStream)
                {
                    campos = sr.ReadLine().Split(';');
                    try
                    {
                        dni = Convert.ToInt32(campos[0].Trim());
                        numero = Convert.ToInt32(campos[2].Trim());
                        saldo = Convert.ToInt32(campos[3].Trim());
                    }
                    catch(FormatException fe)
                    {
                        MessageBox.Show("Error de Formato" + fe.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }             
                    string nombre = campos[1].Trim();
                    
                    Cuenta c = banco.AgregarCuenta(numero, dni,nombre);
                    c.Saldo = saldo;
                }
                sr.Close();
                archivo.Close();
            }
        }

        private void btnExportarCuentas_Click(object sender, EventArgs e)
        {
            string name;
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                archivo = new FileStream(name + ".CSV", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(archivo);
                for (int i = 0; i < banco.CantidadCuentas; i++)
                {
                    Cuenta c = banco[i];
                    if (c.Saldo > 10000)
                    {
                        sw.WriteLine(c);
                    }
                }
                sw.Close();
                archivo.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string name = Path.Combine(Application.StartupPath, "ejercicio1.dat");
            if (File.Exists(name))
            {
                archivo = new FileStream(name, FileMode.Open, FileAccess.Read);
                banco = (Banco)bf.Deserialize(archivo);
                archivo.Close();
            }
            else
            {
                banco = new Banco();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string name = Path.Combine(Application.StartupPath, "ejercicio1.dat");
            archivo = new FileStream(name, FileMode.Create, FileAccess.Write);
            bf.Serialize(archivo, banco);
            archivo.Close();
        }

        private void btnResguardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName + ".CSV";
                archivo = new FileStream(name, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(archivo);
                for (int i = 0; i < banco.CantidadCuentas; i++)
                {
                    sw.WriteLine("cuenta;" + banco[i]);
                }
                for (int i = 0; i < banco.CantidadClientes; i++)
                {
                    sw.WriteLine("cliente;" + banco[i].Titular);
                }
                sw.Close();
                archivo.Close();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }
    }
}
