using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace QRCode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
           

            string strContent = txtContent.Text.Trim();
            if (!string.IsNullOrEmpty(strContent))
            {
                string strCode = strContent;
                QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode qrcode = new QRCoder.QRCode(qrCodeData);

                // qrcode.GetGraphic 方法可参考最下发“补充说明”
                Bitmap qrCodeImage = qrcode.GetGraphic(5, Color.Black, Color.White, null, 15, 6, false);
                 
                 
                picQR.Image = qrCodeImage;
                
            }
            else
            {
                MessageBox.Show("请输入内容再生成!");
            }
            
        }


    }
}
