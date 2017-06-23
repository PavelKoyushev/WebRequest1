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
using System.Net;

namespace WebRequest_сервера
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создать объект запроса
            WebRequest request = WebRequest.Create(txb_url.Text);

            // Получить ответ с сервера
            WebResponse response = request.GetResponse();

            // Получаем поток данных из ответа
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                // Выводим исходный код страницы
                string line;
                while ((line = stream.ReadLine()) != null)
                    txb_sourceCode.Text += line + System.Environment.NewLine;
            }

            // Получаем некоторые данные о сервере
            string messageServer = "Целевой URL: \t" + request.RequestUri + System.Environment.NewLine
                + System.Environment.NewLine + "Метод запроса: \t" + request.Method
                + System.Environment.NewLine +
                "Тип полученных данных: \t" + response.ContentType
                + System.Environment.NewLine + "Длина ответа: \t" + response.ContentLength
                + System.Environment.NewLine + "Заголовки";

            // Получаем заголовки, используем LINQ
            WebHeaderCollection whc = response.Headers;
            var headers = Enumerable.Range(0, whc.Count)
                                    .Select(p =>
                                    {
                                        return new
                                        {
                                            Key = whc.GetKey(p),
                                            Names = whc.GetValues(p)
                                        };
                                    });

            foreach (var item in headers)
            {
                messageServer += System.Environment.NewLine + item.Key + ":";
                foreach (var n in item.Names)
                    messageServer += "\t" + n;
            }
            txb_serverInfo.Text = messageServer;
        }
    }
}
