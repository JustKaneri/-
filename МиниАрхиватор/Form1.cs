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

namespace МиниАрхиватор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Архивация.
        /// </summary>
        /// <param name="baseFile">исходный файл</param>
        /// <param name="arhivFile">Получаймый файл</param>
        private void Packed(string baseFile,string arhivFile)
        {
            List<byte> listByte = new List<byte>();
            long len;
            byte currentByte;

            BinaryReader fileReader = new BinaryReader(File.Open(baseFile,FileMode.Open));
            BinaryWriter fileWriter = new BinaryWriter(File.Open(arhivFile,FileMode.Create));

            //запись имени файла
            //fileWriter.Write(Path.GetFileName(baseFile));
            len = fileReader.BaseStream.Length;//Lenght file.

            while (fileReader.BaseStream.Position < len) 
            {
                currentByte = fileReader.ReadByte();

                if (listByte.Count == 0)
                    listByte.Add(currentByte);
                else
                {
                    if(currentByte != listByte[listByte.Count-1])
                    {
                        listByte.Add(currentByte);
                            
                        if(listByte.Count == 255)
                        {
                            fileWriter.Write((byte)0);
                            fileWriter.Write((byte)255);

                            //ввод содержмого списка в файл.
                            fileWriter.Write(listByte.ToArray(),0,255);
                            listByte.Clear();
                        }
                    }
                    else //если совпадает
                    {
                        //Если есть не повторяющиеся 
                        if (listByte.Count > 1)
                        {
                            fileWriter.Write((byte)0);
                            fileWriter.Write((byte)(listByte.Count - 1));
                            fileWriter.Write(listByte.ToArray(), 0, listByte.Count - 1);
                            listByte.RemoveRange(0, listByte.Count - 1);
                        }

                        listByte.Add(currentByte);

                        //если файл не закончился
                        if(fileReader.BaseStream.Position < len)
                        {
                            while ((currentByte = fileReader.ReadByte()) == listByte[0])
                            {
                                listByte.Add(currentByte);
                                if(listByte.Count == 255)
                                {
                                    fileWriter.Write((byte)listByte.Count);
                                    fileWriter.Write((byte)listByte[0]);
                                    listByte.Clear();
                                    break;
                                }

                                //Если файл закончился
                                if (fileReader.BaseStream.Position == len)
                                    break;
                            }
                        }

                        //Если есть байты кол-во меньше 255
                        if(listByte.Count > 0)
                        {
                            fileWriter.Write((byte)listByte.Count);
                            fileWriter.Write((byte)listByte[0]);
                            listByte.Clear();
                            
                            //Если не дошли до конца
                            if (fileReader.BaseStream.Position < len)
                                listByte.Add(currentByte);
                        }
                    }
                }
            }

            //Закончился перебор байт в исходном файле
            if(listByte.Count > 0)
            {
                fileWriter.Write((byte)0);
                fileWriter.Write((byte)listByte.Count);
                fileWriter.Write(listByte.ToArray(), 0, listByte.Count);
            }

            fileReader.Close();
            fileWriter.Close();
        }

        private void UnPacked()
        {

        }

        private void BtnPuck_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileBase = openFileDialog1.FileName;
                string fileArh = Path.GetDirectoryName(fileBase) + @"\"+ Path.GetFileNameWithoutExtension(fileBase)+".pack";

                Packed(fileBase, fileArh);
            }
        }
    }
}
