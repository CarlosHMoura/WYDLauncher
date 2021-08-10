using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WYDLauncher
{
	public partial class Config : Form
	{

		public short m_Version;//Patch
		public short m_ResIndex;//ResIndex
		public short m_Smooth;//Smooth
		public short m_Sound;//Sond
		public short m_Music;//Music
		public short m_NotUsed;//NotUsed
		public short m_Brilho;//Brilho
		public short m_Cursor;//Cursor
		public short m_PlayDemo;//PlayDemo
		public short m_FullScreen;//FullScreen
		public short m_UIVersion;//UiVersion
		public short m_CameraRout;//CamerRout
		public short m_DxtEnabled;//DxtEnable
		public short m_KeyType;//KeyType
		public short m_CameraView;//CameraView
		public Config()
		{
			InitializeComponent();

			this.comboBox1.Items.AddRange(new object[] {
			"640x480 (32bit)",//1
			"800x600 (32bit)",//2
			"1024x768 (32bit)",//3
			"1280x1024 (32bit)",//4
			"1600x1200 (32bit)",//5
			"640x480 (16bit)",//6
			"800x600 (16bit)",//7
			"1024x768 (16bit)",//8
			"1280x1024 (16bit)",//9
			"1600x1200 (16bit)",//10
			"3200x2400 (32bit)"});//11

			ReadConfigFile();

			if (m_FullScreen != 0)
			{
				radioButton1.Checked = false;
				radioButton2.Checked = true;
			}
			else
			{
				radioButton1.Checked = true;
				radioButton2.Checked = false;
			}

			comboBox1.SelectedIndex = m_ResIndex;

			if (m_FullScreen != 0)
			{
				radioButton1.Checked = false;
				radioButton2.Checked = true;
			}
			else
			{
				radioButton1.Checked = true;
				radioButton2.Checked = false;
			}

			comboBox1.SelectedIndex = m_ResIndex - 1;

			Efeitos.Value = m_Sound;
			Musica.Value = m_Music;
			Brilho.Value = m_Brilho;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			m_FullScreen = 1;
		}


		public void ReadConfigFile()
		{
			try
			{
				using (BinaryReader reader = new BinaryReader(File.Open("./config.bin", FileMode.Open)))
				{

					do
					{
						m_Version = reader.ReadInt16();
						m_ResIndex = reader.ReadInt16();
						m_Smooth = reader.ReadInt16();
						m_Sound = reader.ReadInt16();
						m_Music = reader.ReadInt16();
						m_NotUsed = reader.ReadInt16();
						m_Brilho = reader.ReadInt16();
						m_Cursor = reader.ReadInt16();
						m_PlayDemo = reader.ReadInt16();
						m_FullScreen = reader.ReadInt16();
						m_UIVersion = reader.ReadInt16();
						m_CameraRout = reader.ReadInt16();
						m_DxtEnabled = reader.ReadInt16();
						m_KeyType = reader.ReadInt16();
						m_CameraView = reader.ReadInt16();

						m_ResIndex = (short)(m_ResIndex - 1);
						if (m_ResIndex == 0)
							m_ResIndex = 1;

					} while (reader.BaseStream.Position < reader.BaseStream.Length);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n Src:" + ex.Source + "\nData:" + ex.Data);
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			m_FullScreen = 0;
		}

		private void Efeitos_ValueChanged(object sender, EventArgs e)
		{
			EfeitosTxt.Text = (Efeitos.Value).ToString();
			m_Sound = (short)Efeitos.Value;
		}

		private void Musica_ValueChanged(object sender, EventArgs e)
		{
			MusicaTxt.Text = (Musica.Value).ToString();
			m_Music = (short)Musica.Value;
		}
		private void Brilho_ValueChanged(object sender, EventArgs e)
		{
			BrilhoTxt.Text = (Brilho.Value).ToString();
			m_Brilho = (short)Brilho.Value;
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			m_ResIndex = (short)(comboBox1.SelectedIndex + 1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}
		public void SaveConfig()
		{

			using (BinaryWriter writer = new BinaryWriter(File.Open("./config.bin", FileMode.Create)))
			{
				try
				{

					writer.Write(m_Version);
					writer.Write(m_ResIndex);
					writer.Write(m_Smooth);
					writer.Write(m_Sound);
					writer.Write(m_Music);
					writer.Write(m_NotUsed);
					writer.Write(m_Brilho);
					writer.Write(m_Cursor);
					writer.Write(m_PlayDemo);
					writer.Write(m_FullScreen);
					writer.Write(m_UIVersion);
					writer.Write(m_CameraRout);
					writer.Write(m_DxtEnabled);
					writer.Write(m_KeyType);
					writer.Write(m_CameraView);
				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + "\n Src:" + ex.Source + "\nData:" + ex.Data);
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void EfeitosTxt_Click(object sender, EventArgs e)
		{

		}

		private void Config_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			SaveConfig();
			//MessageBox.Show("Configurações salvas");
			this.Hide();
		}

        private void strtGameBtn_Click(object sender, EventArgs e)
        {
			ReadConfigFile();
			m_ResIndex = 4;//ResIndex
			m_Smooth = 2;//Smooth
			m_Sound = 0;//Sond
			m_Music = 0;//Music
			m_NotUsed = -1;//NotUsed
			m_Brilho = 57;//Brilho
			m_Cursor = 2;//Cursor
			m_PlayDemo = 1;//PlayDemo
			m_FullScreen = 1;//FullScreen
			m_UIVersion = 1;//UiVersion
			m_CameraRout = 0;//CamerRout
			m_DxtEnabled = 0;//DxtEnable
			m_KeyType = 0;//KeyType
			m_CameraView = 1;//CameraView

			if (m_FullScreen != 0)
			{
				radioButton1.Checked = false;
				radioButton2.Checked = true;
			}
			else
			{
				radioButton1.Checked = true;
				radioButton2.Checked = false;
			}

			comboBox1.SelectedIndex = m_ResIndex;

			Efeitos.Value = m_Sound;
			Musica.Value = m_Music;
			Brilho.Value = m_Brilho;

			MessageBox.Show("Configurações restauradas");
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			m_ResIndex = (short)(comboBox1.SelectedIndex + 1);
		}
    }
}