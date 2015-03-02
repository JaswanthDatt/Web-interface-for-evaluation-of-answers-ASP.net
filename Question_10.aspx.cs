using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;

public partial class Question_10 : System.Web.UI.Page
{
    [Serializable]
    public class Question10_file
    {
        public string ans;
        public string dd_ls;
        public string review;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
         string ques_10 = (string)Session["Login"];
         if (ques_10 == "9182")
         {
             if (!Page.IsPostBack)
             {
                 XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question10_file));
                 Question10_file q10 = new Question10_file();
                 using (Stream fStream = new FileStream(Server.MapPath("~/Question10.xml"), FileMode.Open))
                 {
                     q10 = (Question10_file)xmlSerializer.Deserialize(fStream);
                     TextBox_1.Text = q10.ans;
                     TextBox2.Text = q10.review;
                     DropDownList1.SelectedValue = q10.dd_ls;
                 }
             }
         }
         else
             Server.Transfer("~/Start_Page.aspx");

    }
    protected override void OnPreInit(EventArgs e)
    {
        PreInit += new EventHandler(Page_PreInit);
        Load += new EventHandler(Page_Load);

        // And only then:
        base.OnPreInit(e);
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Wheat";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("~/Question_9.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Question10_file q10 = new Question10_file();
        q10.ans = TextBox_1.Text;
        q10.review = TextBox2.Text;
        q10.dd_ls = DropDownList1.SelectedValue;

        SaveAsXmlFormat(q10, Server.MapPath("~/Question10.xml"));
        
        Server.Transfer("~/End_Test.aspx");

    }
    static void SaveAsXmlFormat(object objGraph, string fileName)
    {
        try
        {
            // Save object to a file named CarData.xml in XML format.
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Question10_file));

            using (Stream fStream = new FileStream(fileName,
              FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
        }
        catch (IOException)
        {
        }

    }
    protected void Button_view_Click(object sender, EventArgs e)
    {
        string ques_10 = (string)Session["Login"];
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question10_file));
        Question10_file q10 = new Question10_file();
        using (Stream fStream = new FileStream(Server.MapPath("~/Question10.xml"), FileMode.Open))
        {
            q10 = (Question10_file)xmlSerializer.Deserialize(fStream);
            TextBox_1.Text = q10.ans;
            TextBox2.Text = q10.review;
            DropDownList1.SelectedValue = q10.dd_ls;
        }
        if (Button_view.Text == "View answer")
        {
            TextBox_1.Visible = true;
            Button_view.Text = "Hide answer";
        }
        else
        {
            TextBox_1.Visible = false;
            Button_view.Text = "View answer";
        }
    }
}