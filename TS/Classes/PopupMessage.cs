using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace TS.Classes
{
    public class PopupMessage
    {
        public void successMessage()
        { 
            PopupNotifier pp = new PopupNotifier();
            pp.IsRightToLeft = false;
            pp.Image = Properties.Resources.success;
            pp.BodyColor = System.Drawing.Color.White;
            pp.ImagePadding = new System.Windows.Forms.Padding(10);
            pp.BorderColor = System.Drawing.Color.Black;

            //pp.ImageSize = ;

            pp.TitlePadding = new System.Windows.Forms.Padding(1);
            pp.TitleFont = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold);
            pp.TitleColor = System.Drawing.Color.Green;
            pp.TitleText = "Successful";
             
            pp.ContentPadding = new System.Windows.Forms.Padding(5);
            pp.ContentFont = new System.Drawing.Font("Century Gothic", 10);
            pp.ContentText = "Record Successfully Saved";

            pp.Popup();
        }

        public void updateMessage()
        {
            PopupNotifier pp = new PopupNotifier();
            pp.IsRightToLeft = false;
            pp.Image = Properties.Resources.refresh;
            pp.BodyColor = System.Drawing.Color.White;
            pp.ImagePadding = new System.Windows.Forms.Padding(10);
            pp.BorderColor = System.Drawing.Color.Black;
         
            pp.TitlePadding = new System.Windows.Forms.Padding(1);
            pp.TitleFont = new System.Drawing.Font("Century Gothic", 12,System.Drawing.FontStyle.Bold);
            pp.TitleColor = System.Drawing.Color.Green;
            pp.TitleText = "Successful";
             
            pp.ContentPadding = new System.Windows.Forms.Padding(5);
            pp.ContentFont = new System.Drawing.Font("Century Gothic", 10); 
            pp.ContentText = "Record Successfully Updated";

            pp.Popup();
        }

        public void deleteMessage()
        {
            PopupNotifier pp = new PopupNotifier();
            pp.IsRightToLeft = false;
            pp.Image = Properties.Resources.delete;
            pp.BodyColor = System.Drawing.Color.White;
            pp.ImagePadding = new System.Windows.Forms.Padding(10);
            pp.BorderColor = System.Drawing.Color.Black;

            //pp.ImageSize = ;
            pp.TitlePadding = new System.Windows.Forms.Padding(1);
            pp.TitleFont = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold);
            pp.TitleColor = System.Drawing.Color.Green;
            pp.TitleText = "Successful";

            pp.ContentPadding = new System.Windows.Forms.Padding(5);
            pp.ContentFont = new System.Drawing.Font("Century Gothic", 10);
            pp.ContentText = "Record Deleted Saved";
            pp.Popup();
        }

        public void infoMessage(string infoMsg)
        {
            PopupNotifier pp = new PopupNotifier();
            pp.IsRightToLeft = false;
            pp.Image = Properties.Resources.information;
            pp.BodyColor = System.Drawing.Color.White;
            pp.ImagePadding = new System.Windows.Forms.Padding(10);
            pp.BorderColor = System.Drawing.Color.Black;

            //pp.ImageSize = ;
            pp.TitleText = "Information";
            pp.TitlePadding = new System.Windows.Forms.Padding(1);
            pp.TitleFont = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold);
            pp.TitleColor = System.Drawing.Color.Blue;

            pp.ContentPadding = new System.Windows.Forms.Padding(5);
            pp.ContentFont = new System.Drawing.Font("Century Gothic", 10);
            pp.ContentText =infoMsg;
            pp.Popup();
        }

    }
}
