using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_4_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				int[][] arr;
				int n = Convert.ToInt32(textBox1.Text);
				textBox2.Text = "";

				if (n < 1)
				{
					throw new Exception();
				}

				arr = new int[n][];

				for (int i = 0; i < n; i++)
				{
					arr[i] = new int[n];
				}

				int[] res = new int[n];

				Random r = new Random();

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						arr[i][j] = r.Next(-100, 100);
					}
				}


				for (int i = 0; i < n; i++)
				{
					res[i] = 0;

					for (int j = 0; j < n; j++)
					{
						if (arr[j][i] % 2 == 0 && arr[j][i] > 0)
						{
							res[i] += arr[j][i];
						}
					}
				}

				textBox2.Text += ("Изначальный массив\r\n");

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						textBox2.Text += String.Format("{0}\t", arr[i][j]);
					}
					textBox2.Text += "\r\n";
				}

				textBox2.Text += ("\r\nРезультат\r\n");

				for (int i = 0; i < n; i++)
				{
					textBox2.Text += String.Format("{0}\t", res[i]);
				}
			}
			catch (FormatException)
			{
				textBox2.Text += ("Введите корректные значния");
			}
			catch
			{
				textBox2.Text += ("Размер массива должен быть натуральным числом");
			}
		}
	}
}
