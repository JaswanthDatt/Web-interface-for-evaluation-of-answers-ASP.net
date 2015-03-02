using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;

public partial class Question_1 : System.Web.UI.Page
{
    [Serializable]
    public class Question1
    {
        public string ans;
        public string dd_ls;
        public string review;

    }

    protected override void OnPreInit(EventArgs e)
    {
        PreInit += new EventHandler(Page_PreInit);
        Load += new EventHandler(Page_Load);

        base.OnPreInit(e);
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Blue";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string ques_1 = (string)Session["Login"];
        if (ques_1=="9182")
        {
            if (!Page.IsPostBack)
            {
               
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question1));
                Question1 q1 = new Question1();
                using (Stream fStream = new FileStream(Server.MapPath("~/Question1.xml"), FileMode.Open))
                {
                    q1 = (Question1)xmlSerializer.Deserialize(fStream);
                    TextBox_1.Text = q1.ans;
                    TextBox2.Text = q1.review;
                    DropDownList1.SelectedValue = q1.dd_ls;
                }
            }
        }
            else
                Server.Transfer("~/Start_Page.aspx");
       }

    protected void Button_view_Click(object sender, EventArgs e)
    {

        string ques_1 = (string)Session["Login"];
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question1));
        Question1 q1 = new Question1();
        using (Stream fStream = new FileStream(Server.MapPath("~/Question1.xml"), FileMode.Open))
        {
            q1 = (Question_1.Question1)xmlSerializer.Deserialize(fStream);
            TextBox_1.Text = q1.ans;
            TextBox2.Text = q1.review;
            DropDownList1.SelectedValue = q1.dd_ls;
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("~/Start_Page.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        Question1 q1 = new Question1();
        q1.ans = TextBox_1.Text;
        q1.review = TextBox2.Text;
        q1.dd_ls = DropDownList1.SelectedValue;

        SaveAsXmlFormat(q1, Server.MapPath("~/Question1.xml"));

        Server.Transfer("~/Question_2.aspx");
    }

    static void SaveAsXmlFormat(object objGraph, string fileName)
    {
        try
        {
           
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Question1));

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

}