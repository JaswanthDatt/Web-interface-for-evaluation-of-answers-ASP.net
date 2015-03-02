using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;

public partial class Question_8 : System.Web.UI.Page
{
    [Serializable]
    public class Question8_file
    {
        public string ans;
        public string exception;
        public string dd_ls;
        public string review;        

    }

   
    protected void Page_Load(object sender, EventArgs e)
    {
        string ques_8 = (string)Session["Login"];
        if (ques_8 == "9182")
        {
            if (!Page.IsPostBack)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question8_file));
                Question8_file q8 = new Question8_file();
                using (Stream fStream = new FileStream(Server.MapPath("~/Question8.xml"), FileMode.Open))
                {
                    q8 = (Question8_file)xmlSerializer.Deserialize(fStream);
                    TextBox_1.Text = q8.ans;
                    TextBox2.Text = q8.review;
                    DropDownList1.SelectedValue = q8.dd_ls;
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
        Page.Theme = "Orchid";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("~/Question_7.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Question8_file q8 = new Question8_file();
        q8.ans = TextBox_1.Text;
        q8.exception = TextBox3.Text;
        q8.review = TextBox2.Text;
        q8.dd_ls = DropDownList1.SelectedValue;

        SaveAsXmlFormat(q8, Server.MapPath("~/Question8.xml"));       
        Server.Transfer("~/Question_9.aspx");

    }
    static void SaveAsXmlFormat(object objGraph, string fileName)
    {
        try
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Question8_file));
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
        string ques_8 = (string)Session["Login"];       
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question8_file));
        Question8_file q8 = new Question8_file();
        using (Stream fStream = new FileStream(Server.MapPath("~/Question8.xml"), FileMode.Open))
        {
            q8 = (Question8_file)xmlSerializer.Deserialize(fStream);
            TextBox_1.Text = q8.ans;
            TextBox2.Text = q8.review;
            DropDownList1.SelectedValue = q8.dd_ls;
        }
        if (Button_view.Text == "View answer")
        {
            TextBox_1.Visible = true;
            Button_view.Text = "Hide answer";
            Button3.Text = "View Exception";
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            Button4.Visible = false;
        }
        else
        {
            TextBox_1.Visible = false;
            Button_view.Text = "View answer";
            TextBox4.Visible = false;
            Button4.Visible = false;

        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        string ques_8 = (string)Session["Login"];
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Question8_file));
        Question8_file q8 = new Question8_file();
        using (Stream fStream = new FileStream(Server.MapPath("~/Question8.xml"), FileMode.Open))
        {
            q8 = (Question8_file)xmlSerializer.Deserialize(fStream);
            TextBox3.Text = q8.exception;
            TextBox2.Text = q8.review;
            DropDownList1.SelectedValue = q8.dd_ls;
        }
       
        if (Button3.Text == "View Exception")
        {
            TextBox3.Visible = true;
            Button3.Text = "Hide Exception";
            Button_view.Text = "View answer";
            TextBox_1.Visible = false;
            TextBox4.Visible = true;
            Button4.Visible = true;
        }
        else
        {
            TextBox3.Visible = false;
            Button3.Text = "View Exception";
            TextBox4.Visible = false;
            Button4.Visible = false;
            
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
       
       try
        {
           this.TextBox4.Text = "Try Block";
           
        }
        catch (Exception a)
        {
            this.TextBox4.Text = this.TextBox4.Text + "\n" + "Catch block";
            this.TextBox4.Text = this.TextBox4.Text + "\n" + (a.Message);
        }
        finally
        {
            this.TextBox4.Text = this.TextBox4.Text + "\n" + "Finally Block";

        }
    }
}
